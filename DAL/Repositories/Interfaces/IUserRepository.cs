using DAL.Models.Entities;

namespace DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync();
        Task<User> GetByIdAsync(string userId);
        Task<bool> IsBlockedAsync(string userId);
        Task<bool> UnBlockUserAsync(string userId);
        Task<bool> BlockUserAsync(string userId, int days);
        Task<bool> ChangeUserRoleAsync(string userId, string roleName);
        Task UpdateAsync(User user);
    }
}
