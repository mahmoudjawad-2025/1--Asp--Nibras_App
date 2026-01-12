

namespace DAL.Models.DTO.Requests.Quiz
{
    public class QuizRequest
    {
        public string Title { get; set; }
        public int LessonId { get; set; }
        public List<QuestionRequest> Questions { get; set; } = new();
    }

}
