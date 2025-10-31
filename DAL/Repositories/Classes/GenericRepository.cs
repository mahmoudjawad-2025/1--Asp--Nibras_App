using Azure;
using D_A_L.Data_Base;
using D_A_L.Repositories.Interfaces;
using DAL.Models.Entities;
using DAL.Utils;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace D_A_L.Repositories.Classes
{

    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IUtilsService _utilsService;

        public GenericRepository(ApplicationDbContext context, IUtilsService utilsService)
        {
            _context = context;
            _utilsService = utilsService;
        }


        //-------------------------------------------------------------------------- CreateAsync
        public async Task<int> CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }


        //-------------------------------------------------------------------------- Update
        public async Task<T?> UpdateAsync(
            T? entity = null,
            Expression<Func<T, bool>>? predicate = null,
            Action<T>? updateAction = null)
        {
            // Case 1: Update by predicate + action
            if (predicate != null && updateAction != null)
            {
                var foundEntity = await _context.Set<T>().FirstOrDefaultAsync(predicate);
                if (foundEntity == null) return null;

                updateAction(foundEntity);
                await _context.SaveChangesAsync();
                return foundEntity;
            }

            // Case 2: Update full entity
            if (entity != null)
            {
                _context.Set<T>().Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }

            // Invalid call — neither case matched
            throw new ArgumentException("You must provide either an entity or both predicate and updateAction.");
        }




        //-------------------------------------------------------------------------- Delete
        public async Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }


        //-------------------------------------------------------------------------- ExistsAsync
        public async Task<bool> ExistsAsync(int? id)
        {
            if (id == null) return false;
            return await _context.Set<T>().AnyAsync(x => x.Id == id);
        }


        //-------------------------------------------------------------------------- GetAll (merged with pagination, filter, order, selector)
        public async Task<(IEnumerable<TResult> Items, int TotalCount)> GetAllAsync<TResult>(
            Expression<Func<T, TResult>>? selector = null,
            int? page = null,
            int? pageSize = null,
            Expression<Func<T, bool>>? filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool withTracking = false,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            // Apply tracking option
            if (!withTracking)
                query = query.AsNoTracking();

            // Apply includes (multiple)
            if (includes != null && includes.Any())
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            // Apply filter
            if (filter != null)
                query = query.Where(filter);

            // Apply ordering
            if (orderBy != null)
                query = orderBy(query);

            // Count total
            int totalCount = await query.CountAsync();

            // If no pagination specified → return all
            if (page == null || pageSize == null || pageSize <= 0)
            {
                if (selector == null)
                {
                    var allItems = await query.Cast<TResult>().ToListAsync();
                    return (allItems, totalCount);
                }

                var projected = await query.Select(selector).ToListAsync();
                return (projected, totalCount);
            }

            // Apply pagination
            query = query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value);

            if (selector == null)
            {
                var pagedItems = await query.Cast<TResult>().ToListAsync();
                return (pagedItems, totalCount);
            }

            var pagedProjected = await query.Select(selector).ToListAsync();
            return (pagedProjected, totalCount);
        }


        //-------------------------------------------------------------------------- GetByIdAsync
        public async Task<TResult?> GetByIdAsync<TResult>(
            int id,
            Expression<Func<T, TResult>>? selector = null,
            Expression<Func<T, bool>>? additionalFilter = null,
            bool withTracking = false,
            params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            // Tracking option
            if (!withTracking)
                query = query.AsNoTracking();

            // Includes
            if (includes != null && includes.Any())
            {
                foreach (var include in includes)
                    query = query.Include(include);
            }

            // Filter by ID
            query = query.Where(e => e.Id == id);

            // Optional extra filter
            if (additionalFilter != null)
                query = query.Where(additionalFilter);

            // Apply selector if provided
            if (selector != null)
                return await query.Select(selector).FirstOrDefaultAsync();

            // Return full entity if no selector
            return (TResult?)(object?)await query.FirstOrDefaultAsync();
        }


        //-------------------------------------------------------------------------- SearchAsync 
        public async Task<IEnumerable<T>> SearchAsync(
            string query,
            Expression<Func<T, string>>[] searchableFields,
            int? limit = null)
        {
            if (string.IsNullOrWhiteSpace(query))
                return new List<T>();

            query = _utilsService.NormalizeArabic(query);
            IQueryable<T> q = _context.Set<T>().AsNoTracking();

            // Phrase (exact substring) match
            string phrase = $"%{query}%";
            Expression<Func<T, bool>> combinedPhrase = searchableFields
                .Select(f => (Expression<Func<T, bool>>)(x =>
                    EF.Functions.Like(EF.Property<string>(x, _utilsService.GetPropertyName(f)), phrase)))
                .Aggregate((prev, next) => _utilsService.OrElse(prev, next));

            var phraseMatches = await q.Where(combinedPhrase).ToListAsync();
            if (phraseMatches.Any())
                return limit.HasValue ? phraseMatches.Take(limit.Value).ToList() : phraseMatches;

            // Split into words (AND logic)
            var words = query.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var w in words)
            {
                var wPattern = $"%{w}%";
                Expression<Func<T, bool>> wordPredicate = searchableFields
                    .Select(f => (Expression<Func<T, bool>>)(x =>
                        EF.Functions.Like(EF.Property<string>(x, _utilsService.GetPropertyName(f)), wPattern)))
                    .Aggregate((prev, next) => _utilsService.OrElse(prev, next));

                q = q.Where(wordPredicate);
            }

            var results = await q.ToListAsync();
            return limit.HasValue ? results.Take(limit.Value).ToList() : results;
        }



    }
}
