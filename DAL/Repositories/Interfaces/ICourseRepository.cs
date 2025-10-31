using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
namespace DAL.Repositories.Interfaces
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<Course> CreateWithLessonsAsync(Course entity, List<int> lessonIds);
        Task<Course> UpdateWithLessonsAsync(int courseId, Course entity, List<int> lessonIds);
    }
}
