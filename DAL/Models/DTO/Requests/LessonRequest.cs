
using DAL.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace DAL.Models.DTO.Requests
{
    public class LessonRequest
    {
        public string Title { get; set; }
        public int CourseId { get; set; }
        public string? ContentText { get; set; }
        public List<IFormFile>? Files { get; set; }
        public List<FilesTypes>? FileTypes { get; set; }
    }

}
