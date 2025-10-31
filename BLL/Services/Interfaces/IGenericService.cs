using DAL.Models.Entities;
using System.Linq.Expressions;

namespace B_L_L.Services.Interfaces
{
    public interface IGenericService<TRequest, TResponse, TEntity>
    {
        Task<int> CreateAsync(TRequest request);
        Task<TResponse> UpdateAsync(int id, TRequest request);
        Task<int> DeleteAsync(int id);
        Task<bool> ToggleStatusAsync(int id);
        Task<TResult?> GetByIdAsync<TResult>(
            int id,
            Expression<Func<TEntity, TResult>>? selector = null,
            Expression<Func<TEntity, bool>>? additionalFilter = null,
            bool withTracking = false,
            params Expression<Func<TEntity, object>>[] includes);


        Task<IEnumerable<TEntity>> SearchAsync(
            string query,
            Expression<Func<TEntity, string>>[] searchableFields,
            int? limit = null);


        Task<PagedResult<TResult>> GetAllAsync<TResult>(
            Expression<Func<TEntity, TResult>>? selector = null,
            int? page = null,
            int? pageSize = null,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            bool withTracking = false,
            params Expression<Func<TEntity, object>>[] includes);
    }
}
