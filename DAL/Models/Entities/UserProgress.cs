using DAL.Models.Enums;
using System.Text.Json.Serialization;

namespace DAL.Models.Entities
{
    public class UserProgress : BaseModel
    {
        public string UserId { get; set; }
        public User User { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProgressType Type { get; set; } = ProgressType.Thikr;
        public int? RelatedItemId { get; set; }
        public int Count { get; set; }
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }

}
