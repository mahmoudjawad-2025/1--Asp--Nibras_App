

namespace DAL.Models.DTO.Responses.HadithDTO
{
    public class HadithResponse 
    {
        public int Id { get; set; }
        public int IdInBook { get; set; }
        public string ArabicText { get; set; }
        public string EnglishText { get; set; }
        public string EnglishNarrator { get; set; }
        public int HadithBookId { get; set; }
        public int HadithChapterId { get; set; }
    }
}
