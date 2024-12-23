using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces.Service;

namespace Application.Application
{
    public class BaseApplication<TEntity,TReadModelResponse> : IBaseApplication<TEntity, TReadModelResponse> 
        where TEntity : class
        where TReadModelResponse : class

    {
        private readonly IBaseService<TEntity> _service;
        private readonly IMapper _mapper;
        public readonly DateTime _DateTime;


        public BaseApplication(IBaseService<TEntity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
            _DateTime = DateTime.Now;

        }

        public virtual async Task<TReadModelResponse> CreateAsync(TReadModelResponse createModel)
        {
            var entidade = _mapper.Map<TEntity>(createModel);
            var entidadeCriada = await _service.CreateAsync(entidade);
            return _mapper.Map<TReadModelResponse>(entidadeCriada);
        }

        public virtual async Task<TReadModelResponse> CreateAsync(TReadModelResponse createModel, string input)
        {
            var entidade = _mapper.Map<TEntity>(createModel);
            var entidadeCriada = await _service.CreateAsync(entidade);
            return _mapper.Map<TReadModelResponse>(entidadeCriada);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var buscaPorId = await GetByIdAsync(id);
            var entidade = _mapper.Map<TEntity>(buscaPorId);
            await _service.DeleteAsync(entidade);
        }

        public virtual async Task<IEnumerable<TReadModelResponse>> GetAllAsync()
        {
            var result = await _service.GetAllAsync();
            var resultFull = _mapper.Map<IEnumerable<TReadModelResponse>>(result);
            return resultFull;
        }
        public virtual async Task<IEnumerable<TReadModelResponse>> GetRangeAsync(int start, int end)
        {
            var result = await _service.GetRangeAsync(start, end);
            return _mapper.Map<IEnumerable<TReadModelResponse>>(result);
        }
        public virtual async Task<TReadModelResponse> GetByIdAsync(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return _mapper.Map<TReadModelResponse>(result);
        }

        public virtual async Task<TReadModelResponse> UpdateAsync(TReadModelResponse updateModel)
        {
            var entidade = _mapper.Map<TEntity>(updateModel);
            return _mapper.Map<TReadModelResponse>(await _service.UpdateAsync(entidade));
        }
        public virtual async Task<TReadModelResponse> UpdateAsync(TReadModelResponse updateModel, string input)
        {
            var entidade = _mapper.Map<TEntity>(updateModel);
            return _mapper.Map<TReadModelResponse>(await _service.UpdateAsync(entidade));
        }
    }
}
