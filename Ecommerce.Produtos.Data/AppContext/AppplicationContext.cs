using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Data.AppContext
{
    public class AppplicationContext : DbContext
    {
        public AppplicationContext(DbContextOptions<AppplicationContext> options) : base(options)
        {

        }

        public DbSet<ProdutoEntity> Produto { get; set; }
        public DbSet<CategoriaEntity> Categoria { get; set; }
    }
}
