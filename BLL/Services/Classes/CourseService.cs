using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Models.Enums;
using DAL.Repositories.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Http.HttpResults;
using Stripe;

namespace BLL.Services.Classes
{
    public class CourseService : GenericService<CourseRequest, CourseResponse, Course>, ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly IFileService _fileService;
        public CourseService(ICourseRepository repository, IFileService fileService) : base(repository) 
        { 
            _repository = repository;
            _fileService = fileService;
        }
        public async Task<CourseResponse> CreateWithLessonsAsync(CourseRequest request)
        {
            var entity = request.Adapt<Course>();
            entity.createAt = DateTime.UtcNow;
            if (request.MainImage != null)
            {
                var imagePath = await _fileService.UploadAsync(request.MainImage, FilesTypes.Image);
                entity.MainImage = imagePath;
            }
            var created = await _repository.CreateWithLessonsAsync(entity, request.LessonIds);
            var adapted = created.Adapt<CourseResponse>();
            adapted.LessonIds = request.LessonIds;
            return adapted;
        }

        public async Task<CourseResponse> UpdateWithLessonsAsync(int id, CourseRequest request)
        {
            var course = await _repository.GetByIdAsync<Course>(id)
                         ?? throw new Exception("Course not found");

            // Delete old main image if replaced
            if (request.MainImage != null)
            {
                if (!string.IsNullOrEmpty(course.MainImage))
                    await _fileService.DeleteAsync(course.MainImage, FilesTypes.Image);

                var imagePath = await _fileService.UploadAsync(request.MainImage, FilesTypes.Image);
                course.MainImage = imagePath;
            }

            course.Title = request.Title;
            course.Description = request.Description;

            var updated = await _repository.UpdateWithLessonsAsync(id, course, request.LessonIds);

            var response = updated.Adapt<CourseResponse>();
            response.LessonIds = request.LessonIds;
            return response;
        }



    }

}
