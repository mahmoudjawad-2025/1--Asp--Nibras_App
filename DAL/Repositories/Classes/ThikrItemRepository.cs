using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.Entities.Thikr;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class ThikrItemRepository : GenericRepository<ThikrItem>, IThikrItemRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public ThikrItemRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetByCategoryIdAsync
        public async Task<List<ThikrItem>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.ThikrItems.Where(i => i.ThikrCategoryId == categoryId).ToListAsync();
        }



        //-------------------------------------------------------------------------- GetByCountAsync
        public async Task<List<ThikrItem>> GetByCountAsync(int minCount, int maxCount)
        {
            return await _context.ThikrItems
                .Where(i => i.Count >= minCount && i.Count <= maxCount)
                .ToListAsync();
        }
    }
}
