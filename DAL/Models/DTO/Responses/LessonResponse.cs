using DAL.Models.DTO.Responses.Quiz;
using DAL.Models.Enums;
using System.Text.Json.Serialization;

namespace DAL.Models.DTO.Responses
{
    public class LessonResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? ContentText { get; set; }
        public List<FileResponse> Files { get; set; } = new();
        public int? CourseId { get; set; }
        public List<int> QuizIds { get; set; } = null;
    }
}
