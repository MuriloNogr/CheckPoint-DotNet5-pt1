using Ecommerce.Produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Produtos.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<CategoriaEntity> Categoria { get; set; }
    }
}
