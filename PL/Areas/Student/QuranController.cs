
using BLL.Services.Interfaces; 
using Microsoft.AspNetCore.Authorization;
using DAL.Models.Entities.QuranEntities;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace PL.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class QuranController : ControllerBase
    {
        private readonly IQuranService _quranService;
        public QuranController(IQuranService quranService)
        {
            _quranService = quranService;
        }



        //-------------------------------------------------------------------------- GetAllSurahsAsync
        [HttpGet("surahs")]
        public async Task<IActionResult> GetAllSurahsAsync()
        {
            var surahs = await _quranService.GetAllSurahsAsync();
            return Ok(surahs);
        }


        //-------------------------------------------------------------------------- GetSurah
        [HttpGet("surahs/{number}")]
        public async Task<IActionResult> GetSurah(int number)
        {
            var surah = await _quranService.GetSurahAsync(number);
            if (surah == null) return NotFound();
            return Ok(surah);
        }


        //-------------------------------------------------------------------------- GetAyah
        [HttpGet("surahs/{surahNumber}/ayahs/{ayahNumber}")]
        public async Task<IActionResult> GetAyah(int surahNumber, int ayahNumber)
        {
            var ayah = await _quranService.GetAyahAsync(surahNumber, ayahNumber);
            if (ayah == null) return NotFound();
            return Ok(ayah);
        }


        //-------------------------------------------------------------------------- Search
        [HttpGet("search")]
        public async Task<IActionResult> Search([FromQuery] string q, [FromQuery] int limit = 50)
        {
            var results = await _quranService.SearchAyahsAsync(q, limit);
            return Ok(results);
        }

        [HttpGet("SearchGeneric")]
        public async Task<IActionResult> SearchGeneric([FromQuery] string query)
        {
            var results = await _quranService.SearchAsync(
                query,
                new Expression<Func<Ayah, string>>[]
                {
                    x => x.NormalizedText,
                    x => x.Text
                    //x => x.EnglishTitle
                },
                limit: 20
            );

            return Ok(results);
        }

    }
}
