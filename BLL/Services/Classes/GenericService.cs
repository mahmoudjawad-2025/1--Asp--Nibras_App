using B_L_L.Services.Interfaces;
using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
using DAL.Models.Enums;
using Mapster;
using OpenQA.Selenium;
using System.Linq.Expressions;

namespace B_L_L.Services.Classes
{
    public class GenericService<TRequest, TResponse, TEntity> : IGenericService<TRequest, TResponse, TEntity>
        where TEntity : BaseModel
    {
        private readonly IGenericRepository<TEntity> _repository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            _repository = genericRepository;
        }


        //-------------------------------------------------------------------------- Create
        public async Task<int> CreateAsync(TRequest request)
        {
            var entity = request.Adapt<TEntity>();
            return await _repository.CreateAsync(entity);
        }


        //-------------------------------------------------------------------------- Update
        public async Task<TResponse> UpdateAsync(int id, TRequest request)
        {
            var entity = await _repository.GetByIdAsync<TEntity>(id);
            if (entity is null) throw new NotFoundException($"Entity with ID {id} not found");

            var updatedEntity = request.Adapt(entity);
            var newEntity = await _repository.UpdateAsync(updatedEntity);
            return newEntity.Adapt<TResponse>();
        }


        //-------------------------------------------------------------------------- Delete
        public async Task<int> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync<TEntity>(id);
            if (entity is null) return 0;
            return await _repository.DeleteAsync(entity);
        }


        //-------------------------------------------------------------------------- ToggleStatus
        public async Task<bool> ToggleStatusAsync(int id)
        {
            var entity = await _repository.GetByIdAsync<TEntity>(id);
            if (entity is null) return false;

            entity.status = entity.status == Status.active ? Status.inActive : Status.active;
            await _repository.UpdateAsync(entity);
            return true;
        }


        //-------------------------------------------------------------------------- GetAll
        public async Task<PagedResult<TResult>> GetAllAsync<TResult>(
            Expression<Func<TEntity, TResult>>? selector = null,
            int? page = null,
            int? pageSize = null,
            Expression<Func<TEntity, bool>>? filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            bool withTracking = false,
            params Expression<Func<TEntity, object>>[] includes)
        {
            var (entities, totalCount) = await _repository.GetAllAsync(
                selector,
                page,
                pageSize,
                filter,
                orderBy,
                withTracking,
                includes
            );

            return new PagedResult<TResult>
            {
                Items = entities,
                TotalCount = totalCount,
                Page = page ?? 1,
                PageSize = pageSize ?? totalCount // if no pagination
            };
        }


        //-------------------------------------------------------------------------- GetByIdAsync
        public async Task<TResult?> GetByIdAsync<TResult>(
            int id,
            Expression<Func<TEntity, TResult>>? selector = null,
            Expression<Func<TEntity, bool>>? additionalFilter = null,
            bool withTracking = false,
            params Expression<Func<TEntity, object>>[] includes)
        {
            return await _repository.GetByIdAsync(
                id,
                selector,
                additionalFilter,
                withTracking,
                includes
            );
        }



        //-------------------------------------------------------------------------- search
        public async Task<IEnumerable<TEntity>> SearchAsync(
            string query,
            Expression<Func<TEntity, string>>[] searchableFields,
            int? limit = null)
        {
            return await _repository.SearchAsync(query, searchableFields, limit);
        }
    }
}
