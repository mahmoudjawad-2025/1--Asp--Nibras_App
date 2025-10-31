using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.Entities.Thikr;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class ThikrCategoryRepository : GenericRepository<ThikrCategory>, IThikrCategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public ThikrCategoryRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }

        //-------------------------------------------------------------------------- GetAllCategoriesAudiosAsync
        public async Task<List<string>> GetAllCategoriesAudiosAsync()
        {
            return await _context.ThikrCategories.Select(c => c.AudioUrl).ToListAsync();
        }



        //-------------------------------------------------------------------------- SearchAllWithItemsAsync
        public async Task<List<ThikrCategory>> SearchAllWithItemsAsync(string query)
        {
            return await _context.ThikrCategories
                .Include(c => c.ThikrItems)
                .Where(c => c.Title.Contains(query) ||
                            c.NormalizedText.Contains(query) ||
                            c.ThikrItems.Any(i => i.Text.Contains(query) || i.NormalizedText.Contains(query)))
                .ToListAsync();
        }
    }
}
