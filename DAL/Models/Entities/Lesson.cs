using DAL.Models.Entities.QuizEntities;
using DAL.Models.Enums;

namespace DAL.Models.Entities
{
    public class Lesson : BaseModel
    {
        public string Title { get; set; }
        public string? ContentText { get; set; }
        public ICollection<LocalFile> Files { get; set; } = new List<LocalFile>();
        public int? CourseId { get; set; } = null;
        public Course? Course { get; set; }
        public ICollection<Quiz> Quizes { get; set; }
    }
}
