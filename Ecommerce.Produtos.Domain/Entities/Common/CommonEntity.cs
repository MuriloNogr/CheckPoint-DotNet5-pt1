using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Produtos.Domain.Entities.Common
{
    public abstract class CommonEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
