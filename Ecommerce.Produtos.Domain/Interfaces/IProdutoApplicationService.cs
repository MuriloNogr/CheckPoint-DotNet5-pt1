using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        IEnumerable<ProdutoEntity> ObterTodosProdutos();
        ProdutoEntity? ObterProdutoPorId(int id);
        ProdutoEntity? SalvarDadosProduto(ProdutoEntity entity);
        ProdutoEntity? EditarDadosProduto(ProdutoEntity entity);
        ProdutoEntity? DeletarDadosProduto(int id);
    }
}