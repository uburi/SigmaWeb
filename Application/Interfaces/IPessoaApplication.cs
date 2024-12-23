using Application.DataTransferObjects;
using Domain.Entities;
using Domain.Utils;
using Radzen;

namespace Application.Interfaces
{
    public interface IPessoaApplication : IBaseApplication<Pessoa, PessoaDto>
    {
        ReturnTable<PessoaDto> GetListPlastererWithFilterRadzen(LoadDataArgs args);
    }
}
