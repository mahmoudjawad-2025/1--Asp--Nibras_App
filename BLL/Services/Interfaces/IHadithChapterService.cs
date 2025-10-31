using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;

namespace BLL.Services.Interfaces
{
    public interface IHadithChapterService : IGenericService<HadithChapterRequest, HadithChapterResponse, HadithChapter> 
    {
        Task<IEnumerable<HadithChapterResponse>> GetByBookIdAsync(int bookId);
        Task<IEnumerable<HadithResponse>> GetHadithsByChapterIdAsync(int chapterId);
        Task<HadithResponse> GetRandomHadithByChapterAsync(int chapterId);
        Task<object> GetChapterStatsAsync(int chapterId);
    }
}
