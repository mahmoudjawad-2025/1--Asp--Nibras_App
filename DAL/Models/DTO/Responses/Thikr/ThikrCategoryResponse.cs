

namespace DAL.Models.DTO.Responses.Thikr
{
    public class ThikrCategoryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AudioUrl { get; set; }
        public List<int> ThikrItemsIds { get; set; }
        public List<ThikrItemResponse> ThikrItems { get; set; }
    }
}
