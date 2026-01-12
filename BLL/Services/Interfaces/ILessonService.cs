using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;

namespace BLL.Services.Interfaces
{
    public interface ILessonService : IGenericService<LessonRequest, LessonResponse, Lesson>
    {
        Task<LessonResponse> CreateLessonAsync(LessonRequest request);
        Task<LessonResponse> UpdateLessonAsync(int id, LessonRequest request);
        Task<IEnumerable<LessonResponse>> GetByCourseIdAsync(int courseId);
    }
}
