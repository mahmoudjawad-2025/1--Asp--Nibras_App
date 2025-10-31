using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;

namespace BLL.Services.Interfaces
{
    public interface IHadithService : IGenericService<HadithRequest, HadithResponse, Hadith> 
    {
        Task<IEnumerable<HadithResponse>> GetByChapterIdAsync(int chapterId);
        Task<IEnumerable<HadithResponse>> GetByBookIdAsync(int bookId);
        Task<IEnumerable<HadithResponse>> GetByNarratorAsync(string narrator);
        Task<HadithResponse> GetRandomHadithAsync(int? bookId, int? chapterId);
        Task<object> GetStatsAsync();
    }
}
