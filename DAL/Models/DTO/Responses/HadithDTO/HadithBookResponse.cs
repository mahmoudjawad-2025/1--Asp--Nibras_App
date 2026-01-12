

namespace DAL.Models.DTO.Responses.HadithDTO
{
    public class HadithBookResponse 
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; }
        public string EnglishTitle { get; set; }
        public int ChapterCount { get; set; }
        public int HadithCount { get; set; }
    }
}
