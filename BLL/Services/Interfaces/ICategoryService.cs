using DAL.Models.DTO.Requests;
using DAL.Models.DTO.Responses;
using DAL.Models.Entities;

namespace B_L_L.Services.Interfaces
{
    public interface ICategoryService : IGenericService<CategoryRequest, CategoryResponse, Category>
    {
        Task<int> CreateWithImage(CategoryRequest request);
        Task<CategoryResponse> UpdateWithImageAsync(int id, CategoryRequest request);
    }
}
