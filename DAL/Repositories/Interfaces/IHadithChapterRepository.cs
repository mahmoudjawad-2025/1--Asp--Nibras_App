using DAL.Models.Entities.HadithEntities;

namespace D_A_L.Repositories.Interfaces
{
    public interface IHadithChapterRepository : IGenericRepository<HadithChapter>
    {
        Task<IEnumerable<HadithChapter>> GetByBookIdAsync(int bookId);
        Task<IEnumerable<Hadith>> GetHadithsByChapterIdAsync(int chapterId);
        Task<Hadith> GetRandomHadithByChapterAsync(int chapterId);
        Task<int> GetChapterHadithCountAsync(int chapterId);
    }
}
