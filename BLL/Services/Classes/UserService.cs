using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.User;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace BLL.Services.Classes
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;
        private readonly IEmailSender _emailSender;

        public UserService(IUserRepository userRepository, UserManager<User> userManager, IEmailSender emailSender)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _emailSender = emailSender;
        }


        //-------------------------------------------------------------------------- GetAllAsync
        public async Task<List<UserResponse>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var userDtos = new List<UserResponse>();
            foreach (var user in users)
            {
                var role = await _userManager.GetRolesAsync(user);
                userDtos.Add(new UserResponse
                {
                    Id = user.Id,
                    FullName = user.FullName,
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed,
                    City = user.City,
                    Street = user.Street,
                    RoleName = role.FirstOrDefault(),
                    UserProgresses = user.UserProgresses?.Adapt<List<UserProgressResponse>>()
                           ?? new List<UserProgressResponse>()
                });
            }
            return userDtos;
        }


        //-------------------------------------------------------------------------- GetByIdAsync
        public async Task<UserResponse> GetByIdAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user.Adapt<UserResponse>();
        }


        //-------------------------------------------------------------------------- BlockUserAsync
        public async Task<bool> BlockUserAsync(string userId, int days)
        {
            return await _userRepository.BlockUserAsync(userId, days);
        }


        //-------------------------------------------------------------------------- UnBlockUserAsync
        public async Task<bool> UnBlockUserAsync(string userId)
        {
            return await _userRepository.UnBlockUserAsync(userId);
        }


        //-------------------------------------------------------------------------- IsBlockedAsync
        public async Task<bool> IsBlockedAsync(string userId)
        {
            return await _userRepository.IsBlockedAsync(userId);
        }


        //-------------------------------------------------------------------------- ChangeUserRoleAsync
        public async Task<bool> ChangeUserRoleAsync(string userId, string roleName)
        {
            return await _userRepository.ChangeUserRoleAsync(userId, roleName);
        }


        //-------------------------------------------------------------------------- GetProfileAsync
        public async Task<UserResponse> GetProfileAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) throw new Exception("User not found");

            var role = await _userManager.GetRolesAsync(user);
            return new UserResponse
            {
                Id = user.Id,
                FullName = user.FullName,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                City = user.City,
                Street = user.Street,
                RoleName = role.FirstOrDefault(),
                UserProgresses = user.UserProgresses?.Adapt<List<UserProgressResponse>>()
                           ?? new List<UserProgressResponse>()
            };
        }


        //-------------------------------------------------------------------------- UpdateProfileAsync
        public async Task<UserResponse> UpdateProfileAsync(string userId, UpdateProfileRequest request)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null)
                throw new Exception("User not found");

            // Validate and normalize inputs
            var fullName = request.FullName?.Trim();
            var userName = request.UserName?.Trim();
            var phone = request.PhoneNumber?.Trim();
            var city = request.City?.Trim();
            var street = request.Street?.Trim();

            // Check for empty or invalid 
            if (!string.IsNullOrEmpty(fullName) && fullName.Length < 3)
                throw new Exception("Full name must be at least 3 characters long");
            if (string.IsNullOrEmpty(fullName) && string.IsNullOrEmpty(user.FullName))
                user.FullName = fullName;

            // Check uniqueness and validity
            if (!string.IsNullOrWhiteSpace(userName) &&
                !string.Equals(userName, user.UserName, StringComparison.OrdinalIgnoreCase))
            {
                if (userName.Length < 3)
                    throw new Exception("Username must be at least 3 characters long");

                var existingUser = await _userManager.FindByNameAsync(userName);
                if (existingUser != null)
                    throw new Exception("Username already exists");

                user.UserName = userName;
            }
            if (!string.IsNullOrWhiteSpace(fullName)) user.FullName = fullName;
            if (!string.IsNullOrWhiteSpace(phone)) user.PhoneNumber = phone;
            if (!string.IsNullOrWhiteSpace(city)) user.City = city;
            if (!string.IsNullOrWhiteSpace(street)) user.Street = street;

            // Update 
            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
                throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));

            var roles = await _userManager.GetRolesAsync(user);
            return new UserResponse
            {
                Id = user.Id,
                FullName = user.FullName,
                UserName = user.UserName,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumber = user.PhoneNumber,
                City = user.City,
                Street = user.Street,
                RoleName = roles.FirstOrDefault() ?? "customer",
                UserProgresses = user.UserProgresses?.Adapt<List<UserProgressResponse>>()
                           ?? new List<UserProgressResponse>()
            };
        }


        //-------------------------------------------------------------------------- ChangePasswordAsync
        public async Task<bool> ChangePasswordAsync(string userId, ChangePasswordRequest request)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) throw new Exception("User not found");

            var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);

            if (!result.Succeeded)
                throw new Exception(string.Join(",", result.Errors.Select(e => e.Description)));

            await _emailSender.SendEmailAsync(user.Email, "Password Changed", "<p>Your password was changed successfully.</p>");
            return true;
        }


        //-------------------------------------------------------------------------- ChangeEmailAsync
        public async Task<bool> ChangeEmailAsync(string userId, ChangeEmailRequest request, HttpRequest httpRequest)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) throw new Exception("User not found");

            var token = await _userManager.GenerateChangeEmailTokenAsync(user, request.NewEmail);
            var escapedToken = Uri.EscapeDataString(token);
            var url = $"{httpRequest.Scheme}://{httpRequest.Host}/api/Identity/User/ConfirmNewEmail?userId={user.Id}&newEmail={request.NewEmail}&token={escapedToken}";

            await _emailSender.SendEmailAsync(request.NewEmail, "Confirm new email", $"<a href='{url}'>Confirm your new email</a>");

            return true;
        }


        //-------------------------------------------------------------------------- ConfirmNewEmailAsync
        public async Task<string> ConfirmNewEmailAsync(string userId, string token, string newEmail)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) throw new Exception("User not found");

            var result = await _userManager.ChangeEmailAsync(user, newEmail, token);
            if (!result.Succeeded)
                throw new Exception(string.Join(",", result.Errors.Select(e => e.Description)));

            return "Email updated successfully";
        }
    }
}
