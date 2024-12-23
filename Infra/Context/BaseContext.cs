using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Context
{
    public class BaseContext : DbContext
        
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
