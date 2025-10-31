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
    public class HadithsController : ControllerBase
    {
        private readonly IHadithService _service;

        public HadithsController(IHadithService service)
        {
            _service = service;
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync(c => new HadithResponse
            {
                Id = c.Id,
                IdInBook = c.IdInBook,
                ArabicText = c.ArabicText,
                EnglishNarrator = c.EnglishNarrator,
                EnglishText = c.EnglishText,
                HadithBookId = c.HadithBookId,
                HadithChapterId = c.HadithChapterId
            });
            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id, c => new HadithResponse
            {
                Id = c.Id,
                IdInBook = c.IdInBook,
                ArabicText = c.ArabicText,
                EnglishNarrator = c.EnglishNarrator,
                EnglishText = c.EnglishText,
                HadithBookId = c.HadithBookId,
                HadithChapterId = c.HadithChapterId,
            });
            return result == null ? NotFound() : Ok(result);
        }


        //-------------------------------------------------------------------------- GetByChapter
        [HttpGet("chapter/{chapterId}")]
        public async Task<IActionResult> GetByChapter(int chapterId) =>
            Ok(await _service.GetByChapterIdAsync(chapterId));


        //-------------------------------------------------------------------------- GetByBookId
        [HttpGet("book/{bookId}")]
        public async Task<IActionResult> GetByBookIdAsync(int bookId) =>
            Ok(await _service.GetByBookIdAsync(bookId));


        //-------------------------------------------------------------------------- Search
        [HttpGet("Search")]
        public async Task<IActionResult> Search([FromQuery] string query)
        {
            var results = await _service.SearchAsync(
                query,
                new Expression<Func<Hadith, string>>[]
                {
                    x => x.NormalizedText,
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }


        //-------------------------------------------------------------------------- GetByNarrator
        [HttpGet("englishNarrator/{name}")]
        public async Task<IActionResult> GetByNarratorAsync(string name) =>
            Ok(await _service.GetByNarratorAsync(name));


        //-------------------------------------------------------------------------- GetRandomHadith
        [HttpGet("random")]
        public async Task<IActionResult> GetRandomHadithAsync([FromQuery] int? bookId = null, [FromQuery] int? chapterId = null) =>
            Ok(await _service.GetRandomHadithAsync(bookId, chapterId));


        //-------------------------------------------------------------------------- GetStats
        [HttpGet("stats")]
        public async Task<IActionResult> GetStats() =>
            Ok(await _service.GetStatsAsync());



        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] HadithRequest request)
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
        public async Task<IActionResult> Update(int id, [FromBody] HadithRequest request)
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
            return deleted > 0  ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
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
