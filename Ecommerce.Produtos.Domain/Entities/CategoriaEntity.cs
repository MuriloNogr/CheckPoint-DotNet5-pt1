using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Produtos.Domain.Entities
{
    [Table("TB_PROD_CATEGORIA")]
    public class CategoriaEntity
    {
        [Key]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("descricao")]
        public string Descricao { get; set; } = string.Empty;
    }
}
