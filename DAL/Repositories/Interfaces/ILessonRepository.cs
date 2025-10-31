using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
using DAL.Models.Enums;
using Microsoft.AspNetCore.Http;

namespace DAL.Repositories.Interfaces
{
    public interface ILessonRepository : IGenericRepository<Lesson>
    {
        Task<IEnumerable<Lesson>> GetByCourseIdAsync(int courseId);
    }
}
