using Ecommerce.Produtos.Application.Services;
using Ecommerce.Produtos.Data.AppData;
using Ecommerce.Produtos.Data.Repositories;
using Ecommerce.Produtos.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Ecommerce.Produtos.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(x => {
                x.UseOracle(configuration["ConnectionStrings:Oracle"]);
            });


            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();


            services.AddTransient<ICategoriaApplicationService, CategoriaApplicationService>();
            services.AddTransient<IProdutoApplicationService, ProdutoApplicationService>();
        }
    }
}
