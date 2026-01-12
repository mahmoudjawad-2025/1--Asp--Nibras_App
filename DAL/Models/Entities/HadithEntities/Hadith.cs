namespace DAL.Models.Entities.HadithEntities
{
    public class Hadith : BaseModel
    {
        public int IdInBook { get; set; }
        public string ArabicText { get; set; }
        public string NormalizedText { get; set; }

        public string EnglishNarrator { get; set; }
        public string EnglishText { get; set; }


        public int HadithChapterId { get; set; }
        public HadithChapter HadithChapter { get; set; }

        public int HadithBookId { get; set; }
        public HadithBook HadithBook { get; set; }
    }
}
