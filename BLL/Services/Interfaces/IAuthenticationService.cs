using DAL.Models.DTO.Requests.Auth;
using DAL.Models.DTO.Responses;
using Microsoft.AspNetCore.Http;
namespace B_L_L.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<UserDto> LoginAsync(LoginRequest loginRequest);
        Task<UserDto> RegisterAsync(RegisterRequest registerRequest, HttpRequest request);
        Task<string> ConfirmEmail(string token, string userId);
        Task<bool> ForgotPassword(ForgotPasswordRequest request);
        Task<bool> ResetPassword(ResetPasswordRequest request);

        Task<UserDto> RefreshTokenAsync(RefreshTokenRequest request);
        Task<bool> LogoutAsync(string accessToken);
    }
}
