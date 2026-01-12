using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
using DAL.Models.Entities.Thikr;
using DAL.Models.Enums;

namespace DAL.Repositories.Interfaces
{
    public interface IUserProgressRepository : IGenericRepository<UserProgress>
    {
        Task<IEnumerable<UserProgress>> GetByUserIdAsync(string userId);
        Task<UserProgress?> GetByUserAndItemAsync(string userId, ProgressType type, int? relatedItemId);
    }

}
