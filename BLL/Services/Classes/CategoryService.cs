using B_L_L.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;
using DAL.Models.Enums;
using Mapster;

namespace B_L_L.Services.Classes
{
    public class CategoryService : GenericService<CategoryRequest, CategoryResponse, Category>, ICategoryService
    {
        private readonly ICategoryRepository _repository;

        private readonly IFileService _fileService;

        public CategoryService(ICategoryRepository repository, IFileService fileService) : base(repository)
        {
            _repository = repository;
            _fileService = fileService;
        }

        public async Task<int> CreateWithImage(CategoryRequest request)
        {
            var entity = request.Adapt<Category>();
            entity.createAt = DateTime.UtcNow;

            if (request.MainImage != null)
            {
                var imagePath = await _fileService.UploadAsync(request.MainImage, FilesTypes.Image);
                entity.MainImage = imagePath;
            }

            return await _repository.CreateAsync(entity);
        }

        public async Task<CategoryResponse> UpdateWithImageAsync(int id, CategoryRequest request)
        {
            var category = await _repository.GetByIdAsync<Category>(id)
                            ?? throw new Exception("Category not found");

            category.Name = request.Name;

            if (request.MainImage != null)
            {
                if (!string.IsNullOrEmpty(category.MainImage))
                    await _fileService.DeleteAsync(category.MainImage, FilesTypes.Image);

                var newImage = await _fileService.UploadAsync(request.MainImage, FilesTypes.Image);
                category.MainImage = newImage;
            }

            await _repository.UpdateAsync(category);
            return category.Adapt<CategoryResponse>();
        }

    }
}
