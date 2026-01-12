
using BLL.Services.Interfaces; 
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace PL.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class CourseController : Controller
    {
        private readonly ICourseService _service;
        private readonly IUtilsService utilsService;

        public CourseController(ICourseService service, IUtilsService utilsService)
        {
            _service = service;
            this.utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new CourseResponse
            {
                Id = c.Id,
                Title = c.Title,
                CategoryId = c.CategoryId,
                Description = c.Description,
                LessonIds = c.Lessons.Select(q => q.Id).ToList(),
                MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, c.MainImage, Request)
            });

            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new CourseResponse
            {
                Id = c.Id,
                Title = c.Title,
                CategoryId = c.CategoryId,
                Description = c.Description,
                MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, c.MainImage, Request)
            });
            return result == null ? NotFound() : Ok(result);
        }

    }

}
