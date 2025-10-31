

namespace DAL.Models.DTO.Responses.Quiz
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Options { get; set; }
    }
}
