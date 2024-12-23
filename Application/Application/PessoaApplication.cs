using Application.DataTransferObjects;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;
using Domain.Utils;
using Radzen;


namespace Application.Application
{
    public class PessoaApplication : BaseApplication<Pessoa, PessoaDto>, IPessoaApplication
    {
        private readonly IPessoaService _pessoaService;

        public PessoaApplication(IPessoaService service, IMapper mapper) : base(service, mapper)
        {
            _pessoaService = service;
        }

        public ReturnTable<PessoaDto> GetListPlastererWithFilterRadzen(LoadDataArgs args)
        {
            var tableList = _pessoaService.GetWithFilterRadzen<PessoaDto>(args.Filter, args.OrderBy, args.Skip.Value, args.Top.Value, pessoa => new PessoaDto()
            {
                Pessoa_ID = pessoa.Pessoa_ID,
                Nome_Fantasia = pessoa.Nome_Fantasia,
                CNPJ_CPF = pessoa.CNPJ_CPF
            });

            return tableList;
        }
    }
}
