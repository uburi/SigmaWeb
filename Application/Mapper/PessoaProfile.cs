using Application.DataTransferObjects;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapper
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<Pessoa, PessoaDto>().ReverseMap();
        }
    }
}
