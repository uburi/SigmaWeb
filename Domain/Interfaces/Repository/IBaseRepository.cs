using Domain.Utils;
using System.Linq.Expressions;

namespace Infra.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetRangeAsync(int start, int end);
        Task<TEntity> AddAsync(TEntity obj);
        Task DeleteAsync(TEntity obj);
        Task<TEntity> UpdateAsync(TEntity obj);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null);
        ReturnTable<TType> GetWithFilterRadzen<TType>(string filter, string order, int? skip, int? take, Expression<Func<TEntity, TType>> select) where TType : class;

    }
}
