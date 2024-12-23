using Domain.Entities;
using Infra.Data.Context;
using Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        public readonly DbSet<Pessoa> _DbSet;
        public readonly BaseContext _AppDbContext;

        public PessoaRepository(BaseContext appDbContext) : base(appDbContext)
        {
            _DbSet = appDbContext.Set<Pessoa>(); ;
            _AppDbContext = appDbContext;
        }

        public override async Task<Pessoa> GetByIdAsync(int id)
        {
            var result = from obj in _DbSet select obj;

            return result.FirstOrDefault(x => x.Pessoa_ID == id);
        }
    }
}
