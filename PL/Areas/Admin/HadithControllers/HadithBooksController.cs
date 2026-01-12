using BLL.Services.Interfaces;
using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using DAL.Models.Entities.HadithEntities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Admin.HadithControllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class HadithBooksController : ControllerBase
    {
        private readonly IHadithBookService _service;

        public HadithBooksController(IHadithBookService service)
        {
            _service = service;
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new HadithBookResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                ChapterCount = c.Chapters.Count,
                HadithCount = c.Hadiths.Count

                //QuizIds = c.Quizes.Select(q => q.Id).ToList()
            });
            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new HadithBookResponse
            {
                Id = c.Id,
                ArabicTitle = c.ArabicTitle,
                EnglishTitle = c.EnglishTitle,
                ChapterCount = c.Chapters.Count,
                HadithCount = c.Hadiths.Count

                //QuizIds = c.Quizes.Select(q => q.Id).ToList()
            });
            return result == null ? NotFound() : Ok(result);
        }


        //-------------------------------------------------------------------------- Search
        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string query)
        {
            var results = await _service.SearchAsync(
                query,
                new Expression<Func<HadithBook, string>>[]
                {
                    x => x.ArabicTitle,
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }


        //-------------------------------------------------------------------------- GetChapters
        [HttpGet("{id}/chapters")]
        public async Task<IActionResult> GetChapters(int id) =>
            Ok(await _service.GetChaptersByBookIdAsync(id));


        //-------------------------------------------------------------------------- GetHadiths
        [HttpGet("{id}/hadiths")]
        public async Task<IActionResult> GetHadiths(int id) =>
            Ok(await _service.GetHadithsByBookIdAsync(id));


        //-------------------------------------------------------------------------- GetRandomHadith
        [HttpGet("{id}/random")]
        public async Task<IActionResult> GetRandomHadith(int id) =>
            Ok(await _service.GetRandomHadithByBookAsync(id));


        //-------------------------------------------------------------------------- GetBookStats
        [HttpGet("{id}/stats")]
        public async Task<IActionResult> GetBookStats(int id) =>
            Ok(await _service.GetBookStatsAsync(id));


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] HadithBookRequest request)
        {
            try
            {
                var result = await _service.CreateAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //-------------------------------------------------------------------------- Update
        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] HadithBookRequest request)
        {
            try
            {
                var result = await _service.UpdateAsync(id, request);
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
            return deleted > 0 ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- ToggleStatus
        [HttpPatch("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus([FromRoute] int id)
        {
            var updated = await _service.ToggleStatusAsync(id);
            return updated ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }
    }

}
