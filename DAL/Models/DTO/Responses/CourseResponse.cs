

using System.Text.Json.Serialization;

namespace DAL.Models.DTO.Responses
{
    public class CourseResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public List<int> LessonIds { get; set; }
        [JsonIgnore]
        public string MainImage { get; set; }
        public string MainImageUrl { get; set; }
    }


}
