using Application.DataTransferObjects;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPessoaApplication : IBaseApplication<Pessoa, PessoaDto>
    {
    }
}
