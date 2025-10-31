using BLL.Services.Interfaces; 
using Microsoft.AspNetCore.Authorization;
using DAL.Models.DTO.Requests.Quiz;
using DAL.Models.DTO.Responses.Quiz;
using Microsoft.AspNetCore.Mvc;

namespace PL.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class QuizController : Controller
    {
        private readonly IQuizService _service;
        public QuizController(IQuizService service) { _service = service; }


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
