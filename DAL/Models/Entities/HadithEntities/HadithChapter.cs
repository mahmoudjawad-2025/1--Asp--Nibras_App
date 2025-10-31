namespace DAL.Models.Entities.HadithEntities
{
    public class HadithChapter : BaseModel
    {
        public string ArabicTitle { get; set; }
        public string EnglishTitle { get; set; }

        public int HadithBookId { get; set; }
        public HadithBook HadithBook { get; set; }
        public ICollection<Hadith> Hadiths { get; set; }
    }
}
