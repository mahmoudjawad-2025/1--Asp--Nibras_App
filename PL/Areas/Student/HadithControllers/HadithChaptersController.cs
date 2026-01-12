using BLL.Services.Interfaces; 
using Microsoft.AspNetCore.Authorization;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Student.HadithControllers 
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class HadithChaptersController : ControllerBase
    {
        private readonly IHadithChapterService _service;

        public HadithChaptersController(IHadithChapterService service)
        {
            _service = service;
        }



        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new HadithChapterResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                HadithCount = c.Hadiths.Count

                //QuizIds = c.Quizes.Select(q => q.Id).ToList()
            });
            return Ok(result);
        }



        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new HadithChapterResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                HadithCount = c.Hadiths.Count
            });
            return result == null ? NotFound() : Ok(result);
        }



        //-------------------------------------------------------------------------- GetByBook
        [HttpGet("book/{bookId}")]
        public async Task<IActionResult> GetByBook(int bookId) =>
            Ok(await _service.GetByBookIdAsync(bookId));


        //-------------------------------------------------------------------------- Search
        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string query)
        {
            var results = await _service.SearchAsync(
                query,
                new Expression<Func<HadithChapter, string>>[]
                {
                    x => x.ArabicTitle,
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }


        //-------------------------------------------------------------------------- GetHadiths
        [HttpGet("{id}/hadiths")]
        public async Task<IActionResult> GetHadiths(int id) =>
            Ok(await _service.GetHadithsByChapterIdAsync(id));


        //-------------------------------------------------------------------------- GetRandomHadith
        [HttpGet("{id}/random")]
        public async Task<IActionResult> GetRandomHadith(int id) =>
            Ok(await _service.GetRandomHadithByChapterAsync(id));


        //-------------------------------------------------------------------------- GetStats
        [HttpGet("{id}/stats")]
        public async Task<IActionResult> GetStats(int id) =>
            Ok(await _service.GetChapterStatsAsync(id));

    }
}
