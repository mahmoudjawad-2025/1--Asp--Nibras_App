using BLL.Services.Interfaces; 
using Microsoft.AspNetCore.Authorization;

using DAL.Models.DTO.Requests.HadithDTO;
using DAL.Models.DTO.Responses.HadithDTO;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using DAL.Models.Entities.HadithEntities;

namespace PL.Areas.Student.HadithControllers
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
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

    }
}
