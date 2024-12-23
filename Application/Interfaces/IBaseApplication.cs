using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBaseApplication<TEntity, TReadModelResponse>
        where TEntity : class
        where TReadModelResponse : class
    {
        Task<TReadModelResponse> GetByIdAsync(int id);
        Task<IEnumerable<TReadModelResponse>> GetAllAsync();
        Task<IEnumerable<TReadModelResponse>> GetRangeAsync(int start, int end);
        Task<TReadModelResponse> CreateAsync(TEntity createModel);
        Task<TReadModelResponse> CreateAsync(TEntity createModel, string input);
        Task<TReadModelResponse> UpdateAsync(TEntity updateModel);
        Task<TReadModelResponse> UpdateAsync(TEntity updateModel, string input);

        Task DeleteAsync(int id);
    }
}
