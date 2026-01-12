using D_A_L.Data_Base;
using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities.HadithEntities;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace D_A_L.Repositories.Classes
{

    public class HadithChapterRepository : GenericRepository<HadithChapter>, IHadithChapterRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public HadithChapterRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetByBookIdAsync
        public async Task<IEnumerable<HadithChapter>> GetByBookIdAsync(int bookId) =>
            await _context.HadithChapters.Where(c => c.HadithBookId == bookId).Include(c => c.Hadiths).ToListAsync();


        //-------------------------------------------------------------------------- GetHadithsByChapterIdAsync
        public async Task<IEnumerable<Hadith>> GetHadithsByChapterIdAsync(int chapterId) =>
            await _context.Hadiths.Where(h => h.HadithChapterId == chapterId).ToListAsync();


        //-------------------------------------------------------------------------- GetRandomHadithByChapterAsync
        public async Task<Hadith> GetRandomHadithByChapterAsync(int chapterId) =>
            await _context.Hadiths.Where(h => h.HadithChapterId == chapterId).OrderBy(r => Guid.NewGuid()).FirstOrDefaultAsync();


        //-------------------------------------------------------------------------- GetChapterHadithCountAsync
        public async Task<int> GetChapterHadithCountAsync(int chapterId) =>
            await _context.Hadiths.CountAsync(h => h.HadithChapterId == chapterId);

    }

}
