

using Microsoft.AspNetCore.Http;

namespace DAL.Models.DTO.Requests
{
    public class CourseRequest
    {
        //public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public List<int>? LessonIds { get; set; } = new List<int>();
        //img
        public IFormFile MainImage { get; set; }
    }
}
