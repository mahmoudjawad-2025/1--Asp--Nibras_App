using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests.Thikr;
using DAL.Models.DTO.Requests.UserProgress;
using DAL.Models.DTO.Responses;
using DAL.Models.DTO.Responses.Thikr;
using DAL.Models.Entities;
using DAL.Models.Entities.Thikr;

namespace BLL.Services.Interfaces
{
    public interface IUserProgressService : IGenericService<UserProgress, UserProgressResponse, UserProgress>
    {
        Task<IEnumerable<UserProgressResponse>> GetUserProgressAsync();
        Task<UserProgressResponse> AddOrIncrementAsync(ProgressCreateRequest request);
    }

}
