using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.Entities;
using DAL.Models.Entities.Thikr;
using DAL.Models.Enums;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class UserProgressRepository : GenericRepository<UserProgress>, IUserProgressRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public UserProgressRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetByUserIdAsync
        public async Task<IEnumerable<UserProgress>> GetByUserIdAsync(string userId)
            => await _context.UserProgresses
                .Where(p => p.UserId.ToString() == userId)
                .ToListAsync();


        //-------------------------------------------------------------------------- GetByUserAndItemAsync
        public async Task<UserProgress?> GetByUserAndItemAsync(string userId, ProgressType type, int? relatedItemId)
            => await _context.UserProgresses
                .FirstOrDefaultAsync(p => p.UserId.ToString() == userId && p.Type == type && p.RelatedItemId == relatedItemId);

    }

}
