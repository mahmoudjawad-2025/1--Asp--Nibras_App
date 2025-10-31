using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities.Thikr;

namespace DAL.Repositories.Interfaces
{
    public interface IThikrItemRepository : IGenericRepository<ThikrItem>
    {
        Task<List<ThikrItem>> GetByCategoryIdAsync(int categoryId);
        Task<List<ThikrItem>> GetByCountAsync(int minCount, int maxCount);
    }
}
