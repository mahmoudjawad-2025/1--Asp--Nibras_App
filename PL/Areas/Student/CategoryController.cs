using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace P_L.Areas.Student
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Student")]
    [Authorize(Roles = "Student")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;
        private readonly IUtilsService utilsService;

        public CategoryController(ICategoryService service, IUtilsService utilsService)
        {
            this.service = service;
            this.utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await service.GetAllAsync(c => new CategoryResponse
            {
                Id = c.Id,
                Name = c.Name,
                CoursesIds = c.Courses.Select(q => q.Id).ToList(),
                MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, c.MainImage, Request)
            }
            );

            return Ok(result);
        }


        //-------------------------------------------------------------------------- GetById
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await service.GetByIdAsync(id, c => new CategoryResponse
            {
                Id = c.Id,
                Name = c.Name,
                CoursesIds = c.Courses.Select(q => q.Id).ToList(),
                MainImageUrl = utilsService.GetFileUrl(FilesTypes.Image, c.MainImage, Request)
            }
            );
            return result == null ? NotFound() : Ok(result);
        }

    }
}
