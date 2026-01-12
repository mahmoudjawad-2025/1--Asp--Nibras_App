using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Classes
{
    public class HadithChapterService : GenericService<HadithChapterRequest, HadithChapterResponse, HadithChapter>, IHadithChapterService
    {
        private readonly IHadithChapterRepository _repository;
        public HadithChapterService(IHadithChapterRepository repository) : base(repository)
        {
            _repository = repository;
        }


        //-------------------------------------------------------------------------- GetByBookIdAsync
        public async Task<IEnumerable<HadithChapterResponse>> GetByBookIdAsync(int bookId) =>
            (await _repository.GetByBookIdAsync(bookId))
            .Select(c => new HadithChapterResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                HadithCount = c.Hadiths?.Count ?? 0
            });


        //-------------------------------------------------------------------------- GetHadithsByChapterIdAsync
        public async Task<IEnumerable<HadithResponse>> GetHadithsByChapterIdAsync(int chapterId) =>
            (await _repository.GetHadithsByChapterIdAsync(chapterId))
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


        //-------------------------------------------------------------------------- GetRandomHadithByChapterAsync
        public async Task<HadithResponse> GetRandomHadithByChapterAsync(int chapterId)
        {
            var h = await _repository.GetRandomHadithByChapterAsync(chapterId);
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


        //-------------------------------------------------------------------------- GetChapterStatsAsync
        public async Task<object> GetChapterStatsAsync(int chapterId)
        {
            var hadithCount = await _repository.GetChapterHadithCountAsync(chapterId);
            return new { HadithCount = hadithCount };
        }
    }
}
