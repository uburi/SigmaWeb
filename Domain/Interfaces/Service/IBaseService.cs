using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
