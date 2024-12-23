using Domain.Utils;
using Infra.Data.Context;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly BaseContext _AppDbContext;
        protected readonly DbSet<TEntity> _DbSet;

        public BaseRepository(BaseContext context)
        {
            _AppDbContext = context;
            _DbSet = _AppDbContext.Set<TEntity>();
        }
        public virtual async Task<IEnumerable<TEntity>> GetRangeAsync(int start, int end)
        {
            var query = _DbSet.AsQueryable();

            query = query
                .Skip(start)  
                .Take(end - start + 1)  
                .AsNoTracking();

            return await query.ToListAsync();
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _DbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                var entity = await _DbSet.FindAsync(id);
                _AppDbContext.Entry(entity).State = EntityState.Detached;
                return entity;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {

                await _DbSet.AddAsync(entity);
                await _AppDbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            try
            {
                _AppDbContext.ChangeTracker.Clear();
                _DbSet.Remove(entity);
                await _AppDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                _AppDbContext.ChangeTracker.Clear();
                _DbSet.Update(entity);
                await _AppDbContext.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ReturnTable<TType> GetWithFilterRadzen<TType>(string filter, string order, int? skip, int? take, Expression<Func<TEntity, TType>> select) where TType : class
        {
            var response = new ReturnTable<TType>();

            var query = from obj in _DbSet select obj;

            response.TotalRegister = query.Count();

            if (!string.IsNullOrEmpty(filter))
                query = query.Where(filter);

            if (!string.IsNullOrEmpty(order))
                query = query.OrderBy(order);

            if (skip.HasValue)
                query = query.Skip(skip.Value);

            if (take.HasValue)
                query = query.Take(take.Value);

            response.List = query.AsNoTracking().Select(select).ToList();

            response.TotalRegisterFilter = query.Count();

            return response;
        }
    }
}
