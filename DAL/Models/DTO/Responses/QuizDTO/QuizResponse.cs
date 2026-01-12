

namespace DAL.Models.DTO.Responses.Quiz
{
    public class QuizResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LessonId { get; set; }
        public List<int> QuestionsIds { get; set; }
        public ICollection<QuestionResponse> Questions { get; set; }
    }
}
