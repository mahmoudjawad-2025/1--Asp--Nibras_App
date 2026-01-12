

namespace DAL.Models.JsonModels
{
    public class SurahJsonModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Transliteration { get; set; } 
        public string Type { get; set; }
        public int Total_Verses { get; set; }
        public VerseJsonModel[] Verses { get; set; } 
    }

    public class VerseJsonModel
    {
        public int Id { get; set; } 
        public string Text { get; set; }
    }
}
