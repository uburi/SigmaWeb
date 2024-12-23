using Domain.Utils;
using System.Linq.Expressions;

namespace Domain.Interfaces.Service
{
    public interface IBaseService<T>
    {
        Task<T> CreateAsync(T obj);
        Task DeleteAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetRangeAsync(int start, int end);
        ReturnTable<TType> GetWithFilterRadzen<TType>(string filter, string order, int? skip, int? take, Expression<Func<T, TType>> select) where TType : class;

    }
}
