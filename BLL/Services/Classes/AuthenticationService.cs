using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Auth;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace B_L_L.Services.Classes
{
    public class AuthenticationService : IAuthenticationService
    {
        private static readonly HashSet<string> _revokedTokens = new HashSet<string>();
        // - - - -
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailSender _emailSender;
        private readonly SignInManager<User> _signInManager;
        private readonly IAuthRepository _authRepository;

        public AuthenticationService(
            UserManager<User> userManager, IConfiguration configuration, IEmailSender emailSender, SignInManager<User> signInManager, IAuthRepository authRepository)
        {
            _userManager = userManager;
            _configuration = configuration;
            _emailSender = emailSender;
            _signInManager = signInManager;
            _authRepository = authRepository;
        }


        //-------------------------------------------------------------------------- tokens helpers
        // CreateTokenAsync
        private async Task<string> CreateTokenAsync(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("jwtOptions")["SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(8),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }


        // GenerateRefreshToken
        private string GenerateRefreshToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }


        public async Task<UserDto> RefreshTokenAsync(RefreshTokenRequest request)
        {
            var storedToken = await _authRepository.GetTokenAsync(request.RefreshToken);
            if (storedToken == null || storedToken.IsRevoked || storedToken.ExpiryDate < DateTime.UtcNow)
                throw new Exception("Invalid or expired refresh token");

            var newAccessToken = await CreateTokenAsync(storedToken.User);
            await _authRepository.SaveChangesAsync();

            return new UserDto
            {
                AccessToken = newAccessToken,
                RefreshToken = request.RefreshToken  // Return the SAME refresh token
            };
        }


        // Helper for middleware to check if token is revoked
        public static bool IsTokenRevoked(string token)
        {
            return _revokedTokens.Contains(token);
        }

        //-------------------------------------------------------------------------- Register
        public async Task<UserDto> RegisterAsync(RegisterRequest registerRequest, HttpRequest request)
        {
            // Validate and normalize inputs
            var fullName = registerRequest.FullName?.Trim();
            var userName = registerRequest.UserName?.Trim();
            var phone = registerRequest.PhoneNumber?.Trim();

            // Check for empty or invalid 
            if (string.IsNullOrEmpty(fullName) || fullName.Length < 3)
                throw new Exception("Full name must be at least 3 characters long");

            // Check uniqueness and validity
            if (!string.IsNullOrWhiteSpace(userName))
            {
                if (userName.Length < 3)
                    throw new Exception("Username must be at least 3 characters long");

                var existingUser = await _userManager.FindByNameAsync(userName);
                if (existingUser != null)
                    throw new Exception("Username already exists");
            }

            var user = new User()
            {
                FullName = registerRequest.FullName,
                Email = registerRequest.Email,
                PhoneNumber = registerRequest.PhoneNumber,
                UserName = registerRequest.UserName,
            };

            var result = await _userManager.CreateAsync(user, registerRequest.Password);

            if (result.Succeeded)
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var escapedToken = Uri.EscapeDataString(token);
                var emailUrl = $"{request.Scheme}://{request.Host}/api/Identity/Authentication/ConfirmEmail?token={escapedToken}&userId={user.Id}";

                await _userManager.AddToRoleAsync(user, "Student");
                await _emailSender.SendEmailAsync(user.Email, "Welcome", $"Hello {user.FullName} - <a href='{emailUrl}'> Confirm </a>");

                // Generate tokens
                var accessToken = await CreateTokenAsync(user);
                var refreshToken = GenerateRefreshToken();

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiry = DateTime.UtcNow.AddDays(7);
                await _userManager.UpdateAsync(user);

                return new UserDto
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken
                };
            }
            else
            {
                throw new Exception(string.Join(",", result.Errors.Select(e => e.Description)));
            }
        }


        //-------------------------------------------------------------------------- Login
        public async Task<UserDto> LoginAsync(LoginRequest loginRequest)
        {
            var user = await _userManager.FindByEmailAsync(loginRequest.Email);
            if (user is null)
            {
                throw new Exception("Invalid email or password");
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, loginRequest.Password, true);
            if (result.Succeeded)
            {
                var accessToken = await CreateTokenAsync(user);
                var refreshToken = GenerateRefreshToken();
                var expiry = DateTime.UtcNow.AddDays(7);

                user.RefreshToken = refreshToken;
                user.RefreshTokenExpiry = expiry;
                await _userManager.UpdateAsync(user);

                // Save token in DB
                await _authRepository.AddUserTokenAsync(new UserToken
                {
                    UserId = user.Id,
                    Token = refreshToken,
                    ExpiryDate = expiry,
                    IsRevoked = false
                });
                await _authRepository.SaveChangesAsync();

                return new UserDto
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken
                };
            }

            else if (result.IsLockedOut)
            {
                throw new Exception("your account is locked");
            }
            else if (result.IsNotAllowed)
            {
                throw new Exception("please confirm your email");
            }
            else
            {
                throw new Exception("Check your email or password");
            }
        }


        //-------------------------------------------------------------------------- LogOut
        public async Task<bool> LogoutAsync(string accessToken)
        {
            _revokedTokens.Add(accessToken);

            // Extract user ID from access token
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(accessToken);
            var userId = jwtToken.Claims.First(claim => claim.Type == ClaimTypes.NameIdentifier).Value;

            // Find user and revoke their refresh token
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null && !string.IsNullOrEmpty(user.RefreshToken))
            {
                await _authRepository.RevokeTokenAsync(user.RefreshToken);
                await _authRepository.SaveChangesAsync();
            }

            return true;
        }


        //-------------------------------------------------------------------------- confirm email
        public async Task<string> ConfirmEmail(string token, string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                throw new Exception("User not found");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);

            if (result.Succeeded)
            {
                return "Email confirmed successfully";
            }

            return "Email confirmation failed";
        }


        //-------------------------------------------------------------------------- fogetPassword
        public async Task<bool> ForgotPassword(ForgotPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is null) throw new Exception("user not found");

            var random = new Random();
            var code = random.Next(1000, 9999).ToString();

            user.ResetPasswordCode = code;
            user.ResetPasswordCodeExpiry = DateTime.UtcNow.AddMinutes(15);

            await _userManager.UpdateAsync(user);

            await _emailSender.SendEmailAsync(request.Email, "reset password", $"<p>code is {code}</p>");

            return true;
        }


        //-------------------------------------------------------------------------- Resetpassword
        public async Task<bool> ResetPassword(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user is null) throw new Exception("user not found");

            if (user.ResetPasswordCode != request.Code) return false;

            if (user.ResetPasswordCodeExpiry < DateTime.UtcNow) return false;

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, request.NewPassword);

            if (result.Succeeded)
                await _emailSender.SendEmailAsync(request.Email, "change password", "<h1> your password is changed </h1>");

            return true;
        }
    }
}
