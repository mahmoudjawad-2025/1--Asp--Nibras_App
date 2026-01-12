using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.DTO.Requests.Quran;
using DAL.Models.Entities.QuranEntities;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace DAL.Repositories.Classes
{
    public class QuranRepository : GenericRepository<Ayah>, IQuranRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public QuranRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetAllSurahsAsync
        public async Task<IEnumerable<Surah>> GetAllSurahsAsync()
        => await _context.Surahs
            .Include(s => s.Ayahs)
            .AsNoTracking()
            .OrderBy(s => s.Number)
            .ToListAsync();


        //-------------------------------------------------------------------------- GetSurahByNumberAsync
        public async Task<Surah> GetSurahByNumberAsync(int number)
        {
            return await _context.Surahs
                .Include(s => s.Ayahs.OrderBy(a => a.NumberInSurah))
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Number == number);
        }


        //-------------------------------------------------------------------------- GetAyahsBySurahAsync
        public async Task<IList<Ayah>> GetAyahsBySurahAsync(int surahNumber)
        {
            return await _context.Ayahs
                .AsNoTracking()
                .Where(a => a.SurahNumber == surahNumber)
                .OrderBy(a => a.NumberInSurah)
                .ToListAsync();
        }


        //-------------------------------------------------------------------------- GetAyahAsync
        public async Task<Ayah> GetAyahAsync(int surahNumber, int ayahNumber)
        {
            return await _context.Ayahs
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.SurahNumber == surahNumber && a.NumberInSurah == ayahNumber);
        }


        //-------------------------------------------------------------------------- SearchAyahTextAsync
        public async Task<IList<Ayah>> SearchAyahTextAsync(string query, int limit = 150)
        {
            if (string.IsNullOrWhiteSpace(query)) return new List<Ayah>();
            query = _utilsService.NormalizeArabic(query);

            var q = _context.Ayahs.AsNoTracking();

            // 1 Phrase (exact contiguous) search first
            var phrase = $"%{query}%";
            var phraseMatches = await q
                .Where(a => EF.Functions.Like(a.NormalizedText, phrase))
                .OrderBy(a => a.GlobalNumber)
                .Take(limit)
                .ToListAsync();

            if (phraseMatches.Any()) return phraseMatches;

            // 2 If no phrase match, split into words and require ALL words (AND) — better precision
            var words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 0) return new List<Ayah>();

            IQueryable<Ayah> filtered = q;
            foreach (var w in words)
            {
                var wPattern = $"%{w}%";
                filtered = filtered.Where(a => EF.Functions.Like(a.NormalizedText, wPattern));
            }

            return await filtered
                .OrderBy(a => a.GlobalNumber)
                .Take(limit)
                .ToListAsync();
        }
    }
}
