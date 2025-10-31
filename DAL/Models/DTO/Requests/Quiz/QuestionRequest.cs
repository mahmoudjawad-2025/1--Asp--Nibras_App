

namespace DAL.Models.DTO.Requests.Quiz
{
    public class QuestionRequest
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}
