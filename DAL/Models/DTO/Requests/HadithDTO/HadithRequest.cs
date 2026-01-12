

namespace DAL.Models.DTO.Requests.HadithDTO
{
    public class HadithRequest
    {
        public int IdInBook { get; set; }
        public string ArabicText { get; set; }
        public string NormalizedText { get; set; }
        public string EnglishNarrator { get; set; }
        public string EnglishText { get; set; }
        public int HadithChapterId { get; set; }
        public int HadithBookId { get; set; }
    }
}
