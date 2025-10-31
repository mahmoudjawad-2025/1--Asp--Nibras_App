using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.Quran;
using DAL.Models.Entities.QuranEntities;

namespace DAL.Repositories.Interfaces
{
    public interface IQuranRepository : IGenericRepository<Ayah>
    {
        Task<IEnumerable<Surah>> GetAllSurahsAsync();
        Task<Surah> GetSurahByNumberAsync(int number);
        Task<IList<Ayah>> GetAyahsBySurahAsync(int surahNumber);
        Task<Ayah> GetAyahAsync(int surahNumber, int ayahNumber);

        // Search
        Task<IList<Ayah>> SearchAyahTextAsync(string query, int limit = 50);
    }
}
