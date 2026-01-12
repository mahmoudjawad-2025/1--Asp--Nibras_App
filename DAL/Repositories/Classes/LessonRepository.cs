using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;
namespace DAL.Repositories.Classes
{
    public class LessonRepository : GenericRepository<Lesson>, ILessonRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public LessonRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }

        //-------------------------------------------------------------------------- GetByCourseIdAsync
        public async Task<IEnumerable<Lesson>> GetByCourseIdAsync(int courseId)
        {
            return await _context.Lessons
                .Include(l => l.Files)
                .Include(l => l.Quizes)
                .Where(l => l.CourseId == courseId)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
