using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.DTO.Responses.Quiz;
using DAL.Models.Entities.QuizEntities;

namespace BLL.Services.Interfaces
{
    public interface IQuizService : IGenericService<QuizRequest, QuizResponse, Quiz>
    {
        Task<QuizResponse> CreateWithIncludeAsync(QuizRequest request);
        Task<QuizResponse> UpdateWithIncludeAsync(int id, QuizRequest request);

    }

}
