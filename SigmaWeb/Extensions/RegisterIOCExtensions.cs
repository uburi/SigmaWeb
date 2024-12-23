using Application.Application;
using Application.Interfaces;
using Domain.Interfaces.Service;
using Domain.Services;
using Infra.Data.Context;
using Infra.Data.Interfaces;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace SigmaWeb.Extensions
{
    public static class RegisterIOCExtensions
    {
        public static void RegisterIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SigmaDb"))
                .EnableSensitiveDataLogging();
            },  ServiceLifetime.Scoped);

        }
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IPessoaApplication, PessoaApplication>();

        }
    }
}
