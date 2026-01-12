using DAL.Models.Entities;

namespace DAL.Repositories.Interfaces
{
    public interface IAuthRepository
    {
        Task AddUserTokenAsync(UserToken token);
        Task<UserToken?> GetTokenAsync(string token);
        Task RevokeTokenAsync(string token);
        Task SaveChangesAsync();
    }
}
