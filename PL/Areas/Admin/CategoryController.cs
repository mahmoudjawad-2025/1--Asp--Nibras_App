using Amazon.DynamoDBv2.Model;
using B_L_L.Services.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Enums;
using DAL.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace P_L.Areas.Admin
{
    [Route("api/[area]/[controller]")]
    [ApiController]
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
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


        //-------------------------------------------------------------------------- Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromForm] CategoryRequest request)
        {
            var id = await service.CreateWithImage(request);
            return Ok(new { id, message = "Category created" });
        }


        //-------------------------------------------------------------------------- Update
        [HttpPatch("Update/{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromForm] CategoryRequest request)
        {
            var updated = await service.UpdateWithImageAsync(id, request);
            return updated is not null ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- ToggleStatus
        [HttpPatch("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatus([FromRoute] int id)
        {
            var updated = await service.ToggleStatusAsync(id);
            return updated ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }


        //-------------------------------------------------------------------------- Delete
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await service.DeleteAsync(id);
            return deleted > 0 ? Ok(new { message = "Done Successfuly!" }) : NotFound(new { message = "Item not found" });
        }
    }
}
