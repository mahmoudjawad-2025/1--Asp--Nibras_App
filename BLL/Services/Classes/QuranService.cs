using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Quran;
using DAL.Models.DTO.Responses.QuranDTO;
using DAL.Models.Entities.QuranEntities;
using DAL.Repositories.Interfaces;
using Microsoft.Extensions.Caching.Memory;

namespace BLL.Services.Classes
{
    public class QuranService : GenericService<AyahRequest, AyahResponse, Ayah>, IQuranService
    {
        private readonly IQuranRepository _repo;
        private readonly IMemoryCache _cache;
        private const string CacheKey = "QuranData";

        public QuranService(IQuranRepository repo, IMemoryCache cache) : base(repo)
        {
            _repo = repo;
            _cache = cache;
        }


        //-------------------------------------------------------------------------- GetAllSurahsAsync
        public async Task<IEnumerable<SurahResponse>> GetAllSurahsAsync()
        {
            if (!_cache.TryGetValue(CacheKey, out IEnumerable<SurahResponse> surahs))
            {
                var entities = await _repo.GetAllSurahsAsync();

                surahs = entities.Select(s => new SurahResponse
                {
                    Id = s.Id,
                    Number = s.Number,
                    Name = s.Name,
                    EnglishName = s.EnglishName,
                    EnglishNameTranslation = s.EnglishNameTranslation,
                    RevelationPlace = s.RevelationPlace,
                    AyahCount = s.AyahCount,
                    Ayahs = s.Ayahs.Select(v => new AyahResponse
                    {
                        Id = v.Id,
                        SurahNumber = v.SurahNumber,
                        NumberInSurah = v.NumberInSurah,
                        GlobalNumber = v.GlobalNumber,
                        Text = v.Text,
                        NormalizedText = v.NormalizedText,
                        Juz = v.Juz,
                        Page = v.Page
                    }).ToList()
                }).ToList();

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromHours(12))
                    .SetAbsoluteExpiration(TimeSpan.FromDays(7));

                _cache.Set(CacheKey, surahs, cacheOptions);
            }

            return surahs;
        }


        //-------------------------------------------------------------------------- GetSurahAsync
        public async Task<SurahResponse> GetSurahAsync(int number)
        {
            // 1 check cache
            if (_cache.TryGetValue(CacheKey, out IEnumerable<SurahResponse> cachedSurahs))
            {
                var surahFromCache = cachedSurahs.FirstOrDefault(s => s.Number == number);
                if (surahFromCache != null)
                    return surahFromCache;
            }

            // 2 DB
            var s = await _repo.GetSurahByNumberAsync(number);
            if (s == null) return null;

            var surah = new SurahResponse
            {
                Id = s.Id,
                Number = s.Number,
                Name = s.Name,
                EnglishName = s.EnglishName,
                EnglishNameTranslation = s.EnglishNameTranslation,
                RevelationPlace = s.RevelationPlace,
                AyahCount = s.AyahCount,
                Ayahs = s.Ayahs.OrderBy(a => a.NumberInSurah).Select(v => new AyahResponse
                {
                    Id = v.Id,
                    SurahNumber = v.SurahNumber,
                    NumberInSurah = v.NumberInSurah,
                    GlobalNumber = v.GlobalNumber,
                    Text = v.Text,
                    NormalizedText = v.NormalizedText,
                    Juz = v.Juz,
                    Page = v.Page
                }).ToList()
            };

            return surah;
        }


        //-------------------------------------------------------------------------- GetAyahAsync
        public async Task<AyahResponse> GetAyahAsync(int surahNumber, int ayahNumber)
        {
            // 1. Try QuranData cache first
            if (_cache.TryGetValue(CacheKey, out IEnumerable<SurahResponse> cachedSurahs))
            {
                var ayahFromCache = cachedSurahs
                    .FirstOrDefault(s => s.Number == surahNumber)?
                    .Ayahs?.FirstOrDefault(a => a.NumberInSurah == ayahNumber);

                if (ayahFromCache != null)
                    return ayahFromCache;
            }

            // 2. Fallback to DB
            var a = await _repo.GetAyahAsync(surahNumber, ayahNumber);
            if (a == null) return null;

            return new AyahResponse
            {
                Id = a.Id,
                SurahNumber = a.SurahNumber,
                NumberInSurah = a.NumberInSurah,
                GlobalNumber = a.GlobalNumber,
                Text = a.Text,
                NormalizedText = a.NormalizedText,
                Juz = a.Juz,
                Page = a.Page
            };
        }


        //-------------------------------------------------------------------------- SearchAyahsAsync
        public async Task<IList<AyahResponse>> SearchAyahsAsync(string query, int limit = 50)
        {
            var ayahs = await _repo.SearchAyahTextAsync(query, limit);

            return ayahs.Select(a => new AyahResponse
            {
                Id = a.Id,
                SurahNumber = a.SurahNumber,
                NumberInSurah = a.NumberInSurah,
                GlobalNumber = a.GlobalNumber,
                Text = a.Text, 
                NormalizedText = a.NormalizedText,
                Juz = a.Juz,
                Page = a.Page
            }).ToList();
        }
    }
}
