
using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Quran;
using DAL.Models.DTO.Responses.QuranDTO;
using DAL.Models.Entities.QuranEntities;

namespace BLL.Services.Interfaces
{
    public interface IQuranService : IGenericService<AyahRequest, AyahResponse, Ayah>
    {
        Task<IEnumerable<SurahResponse>> GetAllSurahsAsync();
        Task<SurahResponse> GetSurahAsync(int number);
        Task<AyahResponse> GetAyahAsync(int surahNumber, int ayahNumber);
        Task<IList<AyahResponse>> SearchAyahsAsync(string query, int limit = 50);
    }
}
