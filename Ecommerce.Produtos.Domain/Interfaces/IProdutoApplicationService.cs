using Ecommerce.Produtos.Domain.Dtos;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface IProdutoApplicationService
    {
        ProdutoDto ObterProdutoPorId(int id);
        IEnumerable<ProdutoDto> ObterTodosProdutos();
        ProdutoDto AdicionarProduto(ProdutoDto entity);
        ProdutoDto EditarProduto(ProdutoDto entity);
        ProdutoDto DeletarProduto(ProdutoDto entity);
    }
}
