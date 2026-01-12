using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.Entities.QuizEntities;

namespace DAL.Repositories.Interfaces
{
    public interface IQuizRepository : IGenericRepository<Quiz>
    {
        Task<Quiz> CreateWithIncludeAsync(Quiz entity, List<QuestionRequest> newQuestions);
        Task<Quiz> UpdateWithIncludeAsync(int id, Quiz entity, List<QuestionRequest> newQuestions);

    }

}
