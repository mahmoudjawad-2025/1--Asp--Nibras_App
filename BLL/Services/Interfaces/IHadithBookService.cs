using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;

namespace BLL.Services.Interfaces
{
    public interface IHadithBookService : IGenericService<HadithBookRequest, HadithBookResponse, HadithBook> 
    {
        Task<IEnumerable<HadithChapterResponse>> GetChaptersByBookIdAsync(int bookId);
        Task<IEnumerable<HadithResponse>> GetHadithsByBookIdAsync(int bookId);
        Task<HadithResponse> GetRandomHadithByBookAsync(int bookId);
        Task<object> GetBookStatsAsync(int bookId);
    }
}
