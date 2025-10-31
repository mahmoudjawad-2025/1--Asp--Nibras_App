

namespace DAL.Models.Entities.Thikr
{
    public class ThikrItem : BaseModel
    {
        public string Text { get; set; }
        public string NormalizedText { get; set; }
        public int Count { get; set; }
        public string Description { get; set; } = "";
        public string Reference { get; set; }

        public int ThikrCategoryId { get; set; }
        public ThikrCategory ThikrCategory { get; set; }
    }
}
