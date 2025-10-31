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


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] HadithChapterRequest request)
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
        public async Task<IActionResult> Update(int id, [FromBody] HadithChapterRequest request)
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
