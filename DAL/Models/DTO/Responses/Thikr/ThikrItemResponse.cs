

namespace DAL.Models.DTO.Responses.Thikr
{
    public class ThikrItemResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public int ThikrCategoryId { get; set; }
    }
}
