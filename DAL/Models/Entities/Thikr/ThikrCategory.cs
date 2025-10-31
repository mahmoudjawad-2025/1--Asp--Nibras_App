
namespace DAL.Models.Entities.Thikr
{
    public class ThikrCategory : BaseModel
    {
        public string Title { get; set; }
        public string NormalizedText { get; set; }
        public string AudioUrl { get; set; }
        public ICollection<ThikrItem> ThikrItems { get; set; }
    }
}
