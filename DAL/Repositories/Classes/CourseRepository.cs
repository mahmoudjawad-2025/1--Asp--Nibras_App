using D_A_L.Data_Base;
using D_A_L.Repositories.Classes;
using DAL.Models.Entities;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Classes
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
        {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public CourseRepository(ApplicationDbContext db, IUtilsService utilsService) : base(db, utilsService)
        {
            _context = db;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- CreateWithLessons
        public async Task<Course> CreateWithLessonsAsync(Course entity, List<int> lessonIds)
        {
            var lessons = await _context.Lessons
                .Where(l => lessonIds.Contains(l.Id))
                .ToListAsync();

            if (lessons.Count != lessonIds.Count)
                throw new Exception("Some lessons do not exist.");

            if (lessons.Any(l => l.CourseId != null))
                throw new Exception("Some lessons are already linked to a course.");

            entity.Lessons = lessons;

            await _context.Courses.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }


        //-------------------------------------------------------------------------- UpdateWithLessons
        public async Task<Course> UpdateWithLessonsAsync(int courseId, Course entity, List<int> lessonIds)
        {
            var course = await _context.Courses
                .Include(c => c.Lessons)
                .FirstOrDefaultAsync(c => c.Id == courseId);

            if (course == null)
                throw new Exception("Course not found.");

            var lessons = await _context.Lessons
                .Where(l => lessonIds.Contains(l.Id))
                .ToListAsync();

            if (lessons.Count != lessonIds.Count)
                throw new Exception("Some lessons do not exist.");

            if (lessons.Any(l => l.CourseId != null && l.CourseId != courseId))
                throw new Exception("Some lessons are already linked to another course.");

            course.Title = entity.Title;
            course.Description = entity.Description;
            course.CategoryId = entity.CategoryId;

            if (!string.IsNullOrEmpty(entity.MainImage))
                course.MainImage = entity.MainImage;

            // Replace lessons
            course.Lessons.Clear();
            foreach (var lesson in lessons)
                course.Lessons.Add(lesson);

            await _context.SaveChangesAsync();
            return course;
        }


    }
}
