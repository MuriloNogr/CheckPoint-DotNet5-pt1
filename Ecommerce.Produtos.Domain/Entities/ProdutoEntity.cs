using Ecommerce.Produtos.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Produtos.Domain.Entities
{
    [Table("tb_prd_produto")]
    public class ProdutoEntity : CommonEntity
    {
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public CategoriaEntity Categoria { get; set; } = new CategoriaEntity();
    }
}
