using B_L_L.Services.Classes;
using B_L_L.Services.Interfaces;
using BLL.Services.Interfaces;
using D_A_L.Data_Base;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Models.Enums;
using DAL.Repositories.Classes;
using DAL.Repositories.Interfaces;
using DAL.Utils;
using Mapster;
using Microsoft.AspNetCore.Http;

namespace BLL.Services.Classes
{
    public class LessonService : GenericService<LessonRequest, LessonResponse, Lesson>, ILessonService
    {
        private readonly ILessonRepository _repository;
        private readonly IFileService _fileService;
        private readonly IUtilsService _utilsService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context; 

        public LessonService(ILessonRepository repository, IFileService fileService, IUtilsService utilsService, IHttpContextAccessor httpContextAccessor, ApplicationDbContext context)
            : base(repository)
        {
            _repository = repository;
            _utilsService = utilsService;
            _fileService = fileService;
            _httpContextAccessor = httpContextAccessor;
            _context = context; 
        }

        //-------------------------------------------------------------------------- CreateLessonAsync
        public async Task<LessonResponse> CreateLessonAsync(LessonRequest request)
        {
            var lesson = new Lesson
            {
                Title = request.Title,
                CourseId = request.CourseId,
                ContentText = request.ContentText
            };

            // Handle file uploads
            if (request.Files != null && request.Files.Count > 0)
            {
                if (request.FileTypes == null || request.FileTypes.Count != request.Files.Count)
                    throw new Exception("FileTypes count must match files count");

                var lessonFiles = new List<LocalFile>();

                for (int i = 0; i < request.Files.Count; i++)
                {
                    var file = request.Files[i];
                    var type = request.FileTypes[i];

                    var fileName = await _fileService.UploadAsync(file, type);
                    lessonFiles.Add(new LocalFile
                    {
                        FileName = fileName,
                        FileType = type
                    });
                }

                lesson.Files = lessonFiles;
            }

            await _repository.CreateAsync(lesson);

            var requestContext = _httpContextAccessor.HttpContext?.Request;

            return new LessonResponse
            {
                Id = lesson.Id,
                Title = lesson.Title,
                ContentText = lesson.ContentText,
                CourseId = lesson.CourseId,
                Files = lesson.Files?.Select(f => new FileResponse
                {
                    FileType = f.FileType,
                    Url = _utilsService.GetFileUrl(f.FileType, f.FileName, requestContext)
                }).ToList() ?? new List<FileResponse>(),
                QuizIds = new List<int>()
            };
        }


        //-------------------------------------------------------------------------- UpdateLessonAsync
        public async Task<LessonResponse> UpdateLessonAsync(int id, LessonRequest request)
        {
            var lesson = await _repository.GetByIdAsync<Lesson>(
                id,
                includes: [l => l.Files, l => l.Quizes]
            ) ?? throw new Exception("Lesson not found");

            
            lesson.Title = request.Title;
            lesson.ContentText = request.ContentText;
            lesson.CourseId = request.CourseId;


            if (lesson.Files != null && lesson.Files.Any())
            {
                var oldFilesToRemove = lesson.Files.ToList();
                foreach (var oldFile in oldFilesToRemove)
                {
                    await _fileService.DeleteAsync(oldFile.FileName, oldFile.FileType);
                    _context.LocalFiles.Remove(oldFile); 
                }
                await _context.SaveChangesAsync(); 
            }

            // Step 2: Add ONLY new files (if provided)
            if (request.Files != null && request.Files.Count > 0)
            {
                if (request.FileTypes == null || request.FileTypes.Count != request.Files.Count)
                    throw new Exception("FileTypes count must match files count");

                for (int i = 0; i < request.Files.Count; i++)
                {
                    var fileName = await _fileService.UploadAsync(request.Files[i], request.FileTypes[i]);
                    lesson.Files.Add(new LocalFile
                    {
                        FileName = fileName,
                        FileType = request.FileTypes[i]
                    });
                }
            }

            await _repository.UpdateAsync(lesson);

            var requestContext = _httpContextAccessor.HttpContext?.Request;
            return new LessonResponse
            {
                Id = lesson.Id,
                Title = lesson.Title,
                ContentText = lesson.ContentText,
                CourseId = lesson.CourseId,
                Files = lesson.Files?.Select(f => new FileResponse
                {
                    FileType = f.FileType,
                    Url = _utilsService.GetFileUrl(f.FileType, f.FileName, requestContext)
                }).ToList() ?? new List<FileResponse>(),
                QuizIds = lesson.Quizes?.Select(q => q.Id).ToList() ?? new List<int>()
            };
        }




        //-------------------------------------------------------------------------- GetByCourseIdAsync
        public async Task<IEnumerable<LessonResponse>> GetByCourseIdAsync(int courseId)
        {
            var lessons = await _repository.GetByCourseIdAsync(courseId);

            var request = _httpContextAccessor.HttpContext?.Request;

            return lessons.Select(l => new LessonResponse
            {
                Id = l.Id,
                Title = l.Title,
                ContentText = l.ContentText,
                CourseId = l.CourseId,
                Files = l.Files?.Select(f => new FileResponse
                {
                    FileType = f.FileType,
                    Url = _utilsService.GetFileUrl(f.FileType, f.FileName, request)
                }).ToList() ?? new List<FileResponse>(),
                QuizIds = l.Quizes?.Select(q => q.Id).ToList() ?? new List<int>()
            }).ToList();
        }

    }
}