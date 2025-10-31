using DAL.Models.Entities.HadithEntities;

namespace D_A_L.Repositories.Interfaces
{
    public interface IHadithBookRepository : IGenericRepository<HadithBook>
    {
        Task<IEnumerable<HadithChapter>> GetChaptersByBookIdAsync(int bookId);
        Task<IEnumerable<Hadith>> GetHadithsByBookIdAsync(int bookId);
        Task<Hadith> GetRandomHadithByBookAsync(int bookId);
        Task<(int ChapterCount, int HadithCount)> GetBookStatsAsync(int bookId);
    }
}
