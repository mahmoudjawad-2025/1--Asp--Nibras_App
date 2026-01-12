using DAL.Models.Enums;
using System.Text.Json.Serialization;

namespace DAL.Models.DTO.Responses
{
    public class UserProgressResponse
    {
        //public int Id { get; set; }
        //public string UserId { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProgressType Type { get; set; }
        public int? RelatedItemId { get; set; }
        public int Count { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
