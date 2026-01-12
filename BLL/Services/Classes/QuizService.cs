using B_L_L.Services.Classes;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.DTO.Responses.Quiz;
using DAL.Repositories.Interfaces;
using Mapster;
using DAL.Models.Entities.QuizEntities;

namespace BLL.Services.Classes
{
    public class QuizService : GenericService<QuizRequest, QuizResponse, Quiz>, IQuizService
    {
        private readonly IQuizRepository _repository;
        public QuizService(IQuizRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<QuizResponse> CreateWithIncludeAsync(QuizRequest request)
        {
            var entity = request.Adapt<Quiz>();
            var created = await _repository.CreateWithIncludeAsync(entity, request.Questions);
            return created.Adapt<QuizResponse>();
        }

        public async Task<QuizResponse> UpdateWithIncludeAsync(int id, QuizRequest request)
        {
            var entity = request.Adapt<Quiz>();
            var updated = await _repository.UpdateWithIncludeAsync(id, entity, request.Questions);
            return updated.Adapt<QuizResponse>();
        }


    }

}
