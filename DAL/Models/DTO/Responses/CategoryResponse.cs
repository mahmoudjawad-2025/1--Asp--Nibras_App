

using System.Text.Json.Serialization;

namespace DAL.Models.DTO.Responses
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> CoursesIds { get; set; }
        [JsonIgnore]
        public string MainImage { get; set; }
        public string MainImageUrl { get; set; }
    }

}
