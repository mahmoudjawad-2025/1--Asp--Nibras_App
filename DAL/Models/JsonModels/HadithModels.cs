

namespace DAL.Models.JsonModels
{
    public class HadithJsonRoot
    {
        public int? Id { get; set; }
        public MetadataJson Metadata { get; set; }
        public List<ChapterJson> Chapters { get; set; }
        public List<HadithJson> Hadiths { get; set; }
    }

    public class MetadataJson
    {
        public int? Id { get; set; }
        public ArabicMeta Arabic { get; set; }
        public EnglishMeta English { get; set; }
    }

    public class ArabicMeta
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Introduction { get; set; }
    }

    public class EnglishMeta
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Introduction { get; set; }
    }

    public class ChapterJson
    {
        public int? Id { get; set; }
        public int? BookId { get; set; }
        public string Arabic { get; set; }
        public string English { get; set; }
    }

    public class HadithJson
    {
        public int? Id { get; set; }
        public int? IdInBook { get; set; }
        public int? ChapterId { get; set; }
        public int? BookId { get; set; }
        public string Arabic { get; set; }
        public EnglishHadith English { get; set; }
    }

    public class EnglishHadith
    {
        public string Narrator { get; set; }
        public string Text { get; set; }
    }

}
