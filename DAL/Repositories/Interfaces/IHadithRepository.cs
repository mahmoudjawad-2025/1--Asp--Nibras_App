using DAL.Models.Entities.HadithEntities;

namespace D_A_L.Repositories.Interfaces
{
    public interface IHadithRepository : IGenericRepository<Hadith>
    {
        Task<IEnumerable<Hadith>> GetByChapterIdAsync(int chapterId);
        Task<IEnumerable<Hadith>> GetByBookIdAsync(int bookId);
        Task<IEnumerable<Hadith>> GetByNarratorAsync(string narrator);
        Task<Hadith> GetRandomHadithAsync(int? bookId, int? chapterId);
        Task<int> GetTotalCountAsync();
    }
}
