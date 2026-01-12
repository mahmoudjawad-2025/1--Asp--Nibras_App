

namespace DAL.Models.JsonModels
{
    public class ThikrJsonModel
    {
        public string Audio { get; set; }
        public List<ThikrJsonItem> Adhkar { get; set; }
    }

    public class ThikrJsonItem
    {
        public string Text { get; set; }
        public int Count { get; set; }
        public string Reference { get; set; }
    }
}
