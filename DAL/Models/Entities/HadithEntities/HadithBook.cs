namespace DAL.Models.Entities.HadithEntities
{
    public class HadithBook : BaseModel
    {
        public string ArabicTitle { get; set; }
        public string ArabicAuthor { get; set; }
        public string ArabicIntroduction { get; set; }
        public string EnglishTitle { get; set; }
        public string EnglishAuthor { get; set; }
        public string EnglishIntroduction { get; set; }

        public ICollection<HadithChapter> Chapters { get; set; }
        public ICollection<Hadith> Hadiths { get; set; }
    }
}
