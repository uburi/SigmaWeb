using Domain.Entities;
using Domain.Interfaces.Service;
using Infra.Data.Interfaces;

namespace Domain.Services
{
    public class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        public PessoaService(IPessoaRepository repository) : base(repository)
        {
        }
    }
}
