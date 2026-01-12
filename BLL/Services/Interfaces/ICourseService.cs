using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;

namespace BLL.Services.Interfaces
{
    public interface ICourseService : IGenericService<CourseRequest, CourseResponse, Course>
    {
        Task<CourseResponse> CreateWithLessonsAsync(CourseRequest request);
        Task<CourseResponse> UpdateWithLessonsAsync(int id, CourseRequest request);


    }
}
