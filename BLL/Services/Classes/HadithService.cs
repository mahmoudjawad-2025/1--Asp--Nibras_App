using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;

namespace BLL.Services.Classes
{
    public class HadithService : GenericService<HadithRequest, HadithResponse, Hadith>, IHadithService
    {
        private readonly IHadithRepository _repository;
        public HadithService(IHadithRepository repository) : base(repository)
        {
            _repository = repository;
        }



        //-------------------------------------------------------------------------- GetByChapterIdAsync
        public async Task<IEnumerable<HadithResponse>> GetByChapterIdAsync(int chapterId) =>
            (await _repository.GetByChapterIdAsync(chapterId)).Select(h => new HadithResponse
            {
                Id = h.Id,
                IdInBook = h.IdInBook,
                ArabicText = h.ArabicText,
                EnglishText = h.EnglishText,
                EnglishNarrator = h.EnglishNarrator,
                HadithBookId = h.HadithBookId,
                HadithChapterId = h.HadithChapterId
            });


        //-------------------------------------------------------------------------- GetByBookIdAsync
        public async Task<IEnumerable<HadithResponse>> GetByBookIdAsync(int bookId) =>
            (await _repository.GetByBookIdAsync(bookId)).Select(h => new HadithResponse
            {
                Id = h.Id,
                IdInBook = h.IdInBook,
                ArabicText = h.ArabicText,
                EnglishText = h.EnglishText,
                EnglishNarrator = h.EnglishNarrator,
                HadithBookId = h.HadithBookId,
                HadithChapterId = h.HadithChapterId
            });



        //-------------------------------------------------------------------------- GetByNarratorAsync
        public async Task<IEnumerable<HadithResponse>> GetByNarratorAsync(string narrator) =>
            (await _repository.GetByNarratorAsync(narrator)).Select(h => new HadithResponse
            {
                Id = h.Id,
                IdInBook = h.IdInBook,
                ArabicText = h.ArabicText,
                EnglishText = h.EnglishText,
                EnglishNarrator = h.EnglishNarrator,
                HadithBookId = h.HadithBookId,
                HadithChapterId = h.HadithChapterId
            });


        //-------------------------------------------------------------------------- GetRandomHadithAsync
        public async Task<HadithResponse> GetRandomHadithAsync(int? bookId, int? chapterId)
        {
            var h = await _repository.GetRandomHadithAsync(bookId, chapterId);
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


        //-------------------------------------------------------------------------- GetStatsAsync
        public async Task<object> GetStatsAsync()
        {
            var total = await _repository.GetTotalCountAsync();
            return new { TotalHadiths = total };
        }
    }
}
