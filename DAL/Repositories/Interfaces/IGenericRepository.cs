
using DAL.Models.Entities;
using System.Linq.Expressions;

namespace D_A_L.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<int> CreateAsync(T entity);
        Task<T?> UpdateAsync(
            T? entity = null,
            Expression<Func<T, bool>>? predicate = null,
            Action<T>? updateAction = null);
        Task<int> DeleteAsync(T entity);
        Task<bool> ExistsAsync(int? id);

        Task<TResult?> GetByIdAsync<TResult>(
            int id,
            Expression<Func<T, TResult>>? selector = null,
            Expression<Func<T, bool>>? additionalFilter = null,
            bool withTracking = false,
            params Expression<Func<T, object>>[] includes);

        Task<IEnumerable<T>> SearchAsync(
            string query,
            Expression<Func<T, string>>[] searchableFields,
            int? limit = null);

        Task<(IEnumerable<TResult> Items, int TotalCount)> GetAllAsync<TResult>(
            Expression<Func<T, TResult>>? selector = null,
            int? page = null,
            int? pageSize = null,
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool withTracking = false,
            params Expression<Func<T, object>>[] includes);
    }
}
