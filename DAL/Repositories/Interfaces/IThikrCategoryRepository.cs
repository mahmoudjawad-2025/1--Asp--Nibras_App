using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities.Thikr;
namespace DAL.Repositories.Interfaces
{
    public interface IThikrCategoryRepository : IGenericRepository<ThikrCategory>
    {
        Task<List<string>> GetAllCategoriesAudiosAsync();
        Task<List<ThikrCategory>> SearchAllWithItemsAsync(string query);
    }
}
