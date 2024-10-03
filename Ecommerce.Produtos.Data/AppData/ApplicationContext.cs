using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        public DbSet<CategoriaEntity> Categoria { get; set; }
        public DbSet<ProdutoEntity> Produto { get; set; }
    }
}
