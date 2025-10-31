using DAL.Models.Enums;
using System.Text.Json.Serialization;

namespace DAL.Models.DTO.Requests.UserProgress
{
    public class ProgressCreateRequest
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ProgressType Type { get; set; }
        public int? RelatedItemId { get; set; }
        public int Count { get; set; } = 1;
    }
}
