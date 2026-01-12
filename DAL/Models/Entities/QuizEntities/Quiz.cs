using System.Text.Json.Serialization;

namespace DAL.Models.Entities.QuizEntities
{
    public class Quiz : BaseModel
    {
        public string Title { get; set; }
        public int LessonId { get; set; }
        [JsonIgnore]
        public Lesson Lesson { get; set; }
        [JsonIgnore]
        public ICollection<Question> Questions { get; set; } = new List<Question>();
    }
}
