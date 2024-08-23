using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        ProdutoEntity ObterPorId(int id);
        IEnumerable<ProdutoEntity> ObterTodos();
        ProdutoEntity Adicionar(ProdutoEntity entity);
        ProdutoEntity Editar(ProdutoEntity entity);
        ProdutoEntity Deletar(ProdutoEntity entity);
    }
}
