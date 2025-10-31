using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;

namespace BLL.Services.Classes
{
    public class HadithBookService : GenericService<HadithBookRequest, HadithBookResponse, HadithBook>, IHadithBookService
    {
        private readonly IHadithBookRepository _repository;
        public HadithBookService(IHadithBookRepository repository) : base(repository)
        {
            _repository = repository;
        }


        //-------------------------------------------------------------------------- GetChaptersByBookIdAsync
        public async Task<IEnumerable<HadithChapterResponse>> GetChaptersByBookIdAsync(int bookId) =>
            (await _repository.GetChaptersByBookIdAsync(bookId))
            .Select(c => new HadithChapterResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                HadithCount = c.Hadiths?.Count ?? 0
            });


        //-------------------------------------------------------------------------- GetHadithsByBookIdAsync
        public async Task<IEnumerable<HadithResponse>> GetHadithsByBookIdAsync(int bookId) =>
            (await _repository.GetHadithsByBookIdAsync(bookId))
            .Select(h => new HadithResponse
            {
                Id = h.Id,
                IdInBook = h.IdInBook,
                ArabicText = h.ArabicText,
                EnglishText = h.EnglishText,
                EnglishNarrator = h.EnglishNarrator,
                HadithBookId = h.HadithBookId,
                HadithChapterId = h.HadithChapterId
            });


        //-------------------------------------------------------------------------- GetRandomHadithByBookAsync
        public async Task<HadithResponse> GetRandomHadithByBookAsync(int bookId)
        {
            var h = await _repository.GetRandomHadithByBookAsync(bookId);
            return h == null ? null : new HadithResponse
            {
                Id = h.Id,
                IdInBook = h.IdInBook,
                ArabicText = h.ArabicText,
                EnglishText = h.EnglishText,
                EnglishNarrator = h.EnglishNarrator,
                HadithBookId = h.HadithBookId,
                HadithChapterId = h.HadithChapterId
            };
        }


        //-------------------------------------------------------------------------- GetBookStatsAsync
        public async Task<object> GetBookStatsAsync(int bookId)
        {
            var (chapterCount, hadithCount) = await _repository.GetBookStatsAsync(bookId);
            return new { ChapterCount = chapterCount, HadithCount = hadithCount };
        }
    }
}
