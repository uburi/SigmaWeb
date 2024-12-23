using Application.DataTransferObjects;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Application
{
    public class PessoaApplication : BaseApplication<Pessoa, PessoaDto>, IPessoaApplication
    {
        public PessoaApplication(IPessoaService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
