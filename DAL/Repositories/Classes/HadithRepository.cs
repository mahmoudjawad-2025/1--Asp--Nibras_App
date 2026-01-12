using D_A_L.Data_Base;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.Entities.HadithEntities;
using DAL.Models.Entities.QuranEntities;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_A_L.Repositories.Classes
{
    public class HadithRepository : GenericRepository<Hadith>, IHadithRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public HadithRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetByChapterIdAsync
        public async Task<IEnumerable<Hadith>> GetByChapterIdAsync(int chapterId) =>
            await _context.Hadiths.Where(h => h.HadithChapterId == chapterId).ToListAsync();


        //-------------------------------------------------------------------------- GetByBookIdAsync
        public async Task<IEnumerable<Hadith>> GetByBookIdAsync(int bookId) =>
            await _context.Hadiths.Where(h => h.HadithBookId == bookId).ToListAsync();


        //-------------------------------------------------------------------------- GetByNarratorAsync
        public async Task<IEnumerable<Hadith>> GetByNarratorAsync(string narrator) =>
            await _context.Hadiths.Where(h => h.EnglishNarrator.Contains(narrator)).ToListAsync();


        //-------------------------------------------------------------------------- GetRandomHadithAsync
        public async Task<Hadith> GetRandomHadithAsync(int? bookId, int? chapterId)
        {
            var query = _context.Hadiths.AsQueryable();
            if (bookId.HasValue) query = query.Where(h => h.HadithBookId == bookId.Value);
            if (chapterId.HasValue) query = query.Where(h => h.HadithChapterId == chapterId.Value);
            return await query.OrderBy(r => Guid.NewGuid()).FirstOrDefaultAsync();
        }


        //-------------------------------------------------------------------------- GetTotalCountAsync
        public async Task<int> GetTotalCountAsync() => await _context.Hadiths.CountAsync();
    }

}
