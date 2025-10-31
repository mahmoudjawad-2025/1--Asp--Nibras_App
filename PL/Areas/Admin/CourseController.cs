
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace PL.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class CourseController : Controller
    {
        private readonly ICourseService _service;
        private readonly IUtilsService utilsService;

        public CourseController(ICourseService service, IUtilsService utilsService)
        {
            _service = service;
            this.utilsService = utilsService;
        }

        

        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] CourseRequest request)
        {
            try
            {
                var result = await _service.CreateWithLessonsAsync(request);
                if (result != null)
                {
                    result.MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, result.MainImage, Request);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Update
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] CourseRequest request)
        {
            try
            {
                var result = await _service.UpdateWithLessonsAsync(id, request);
                if (result != null)
                {
                    result.MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, result.MainImage, Request);
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        //-------------------------------------------------------------------------- ToggleStatus
        [HttpPatch("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus([FromRoute] int id)
        {
            var updated = await _service.ToggleStatusAsync(id);
            return updated ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- Delete
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted > 0 ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
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
