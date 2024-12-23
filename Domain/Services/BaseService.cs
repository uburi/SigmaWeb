using Domain.Interfaces.Service;
using Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity obj)
        {
            try
            {
                var retorno = await _repository.AddAsync(obj);
                return retorno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public virtual async Task DeleteAsync(TEntity obj)
        {
            await _repository.DeleteAsync(obj);
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var retorno = await _repository.GetAllAsync();
            return retorno;
        }
        public virtual async Task<IEnumerable<TEntity>> GetRangeAsync(int start, int end)
        {
            var retorno = await _repository.GetRangeAsync(start, end);
            return retorno;
        }
        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            var retorno = await _repository.GetByIdAsync(id);
            return retorno;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity obj)
        {
            return await _repository.UpdateAsync(obj);
        }
    }
}
