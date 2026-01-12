using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.DTO.Responses.Quiz;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class QuizController : Controller
    {
        private readonly IQuizService _service;
        public QuizController(IQuizService service) { _service = service; }


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create(QuizRequest request)
        {
            try
            {
                var result = await _service.CreateWithIncludeAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Update
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, QuizRequest request)
        {
            try
            {
                var result = _service.UpdateWithIncludeAsync(id, request);
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
            return deleted >0 ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new QuizResponse
            {
                Id = c.Id,
                Title = c.Title,
                LessonId = c.LessonId,
                Questions = c.Questions.Select(ques => new QuestionResponse
                {
                    Id = ques.Id,
                    Text = ques.Text,
                    Options = ques.Options
                }).ToList(),
                QuestionsIds = c.Questions.Select(q => q.Id).ToList(),

            });

            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new QuizResponse
            {
                Id = c.Id,
                Title = c.Title,
                LessonId = c.LessonId,
                QuestionsIds = c.Questions.Select(q => q.Id).ToList(),
                Questions = c.Questions.Select(ques => new QuestionResponse
                {
                    Id = ques.Id,
                    Text = ques.Text,
                    Options = ques.Options
                }).ToList()
                //Questions = c.Questions,

            });
            return result == null ? NotFound() : Ok(result);
        }
    }

}
