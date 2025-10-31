
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace DAL.Models.Entities.QuizEntities
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }

        public string OptionsJson { get; set; }

        [NotMapped]
        public List<string> Options
        {
            get => string.IsNullOrEmpty(OptionsJson)
                   ? new List<string>()
                   : JsonSerializer.Deserialize<List<string>>(OptionsJson);
            set => OptionsJson = JsonSerializer.Serialize(value);
        }
    }

}
