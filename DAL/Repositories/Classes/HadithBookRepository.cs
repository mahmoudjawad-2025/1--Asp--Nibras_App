using D_A_L.Data_Base;
using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities.HadithEntities;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace D_A_L.Repositories.Classes
{
    public class HadithBookRepository : GenericRepository<HadithBook>, IHadithBookRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public HadithBookRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetChaptersByBookIdAsync
        public async Task<IEnumerable<HadithChapter>> GetChaptersByBookIdAsync(int bookId) =>
            await _context.HadithChapters.Where(c => c.HadithBookId == bookId).ToListAsync();


        //-------------------------------------------------------------------------- GetHadithsByBookIdAsync
        public async Task<IEnumerable<Hadith>> GetHadithsByBookIdAsync(int bookId) =>
            await _context.Hadiths.Where(h => h.HadithBookId == bookId).ToListAsync();


        //-------------------------------------------------------------------------- GetRandomHadithByBookAsync
        public async Task<Hadith> GetRandomHadithByBookAsync(int bookId) =>
            await _context.Hadiths.Where(h => h.HadithBookId == bookId)
                .OrderBy(r => Guid.NewGuid()).FirstOrDefaultAsync();


        //-------------------------------------------------------------------------- GetBookStatsAsync
        public async Task<(int ChapterCount, int HadithCount)> GetBookStatsAsync(int bookId)
        {
            var chapters = await _context.HadithChapters.CountAsync(c => c.HadithBookId == bookId);
            var hadiths = await _context.Hadiths.CountAsync(h => h.HadithBookId == bookId);
            return (chapters, hadiths);
        }


    }

}
