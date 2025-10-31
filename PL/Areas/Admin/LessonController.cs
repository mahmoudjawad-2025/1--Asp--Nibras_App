using B_L_L.Services.Interfaces;
using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.DTO.Responses.Quiz;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace PL.Areas.Admin
{

    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class LessonController : Controller
    {
        private readonly ILessonService _service;
        private readonly IUtilsService _utilsService;

        public LessonController(ILessonService service, IUtilsService utilsService)
        {
            _service = service;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] LessonRequest request)
        {
            try
            {
                var result = await _service.CreateLessonAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Update
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] LessonRequest request)
        {
            try
            {
                var result = await _service.UpdateLessonAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Delete
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted > 0  ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- ToggleStatus
        [HttpPatch("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus([FromRoute] int id)
        {
            var updated = await _service.ToggleStatusAsync(id);
            return updated ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {

            var result = await _service.GetAllAsync(c => new LessonResponse
            {
                Id = c.Id,
                Title = c.Title,
                ContentText = c.ContentText,
                CourseId = c.CourseId,
                Files = c.Files.Select(f => new FileResponse
                {
                    FileType = f.FileType,
                    Url = _utilsService.GetFileUrl(f.FileType, f.FileName, Request)
                }).ToList(),
                QuizIds = c.Quizes.Select(q => q.Id).ToList() ?? new List<int>()
            });
            return Ok(result);
        }



        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new LessonResponse
            {
                Id = c.Id,
                Title = c.Title,
                ContentText = c.ContentText,
                CourseId = c.CourseId,
                Files = c.Files.Select(f => new FileResponse
                {
                    FileType = f.FileType,
                    Url = _utilsService.GetFileUrl(f.FileType, f.FileName, Request)
                }).ToList(),
                QuizIds = c.Quizes.Select(q => q.Id).ToList()
            });
            return result == null ? NotFound() : Ok(result);
        }


        //-------------------------------------------------------------------------- GetByCourseId
        [HttpGet("GetByCourseId/{courseId}")]
        public async Task<IActionResult> GetByCourseId(int courseId)
        {
            try
            {
                var result = await _service.GetByCourseIdAsync(courseId);
                if (!result.Any())
                    return NotFound(new { message = "No lessons found for this course." });

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}
