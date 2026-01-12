using D_A_L.Data_Base;
using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
using DAL.Utils;

namespace D_A_L.Repositories.Classes
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public CategoryRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }
    }
}
