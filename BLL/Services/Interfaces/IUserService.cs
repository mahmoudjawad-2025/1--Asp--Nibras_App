using DAL.Models.DTO.Requests.User;
using DAL.Models.DTO.Responses;
using Microsoft.AspNetCore.Http;

namespace BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserResponse>> GetAllAsync();
        Task<UserResponse> GetByIdAsync(string userId);
        Task<bool> BlockUserAsync(string userId, int days);
        Task<bool> UnBlockUserAsync(string userId);
        Task<bool> IsBlockedAsync(string userId);
        Task<bool> ChangeUserRoleAsync(string userId, string roleName);
        Task<UserResponse> GetProfileAsync(string userId);
        Task<UserResponse> UpdateProfileAsync(string userId, UpdateProfileRequest request);
        Task<bool> ChangePasswordAsync(string userId, ChangePasswordRequest request);
        Task<bool> ChangeEmailAsync(string userId, ChangeEmailRequest request, HttpRequest httpRequest);
        Task<string> ConfirmNewEmailAsync(string userId, string token, string newEmail);
    }
}
