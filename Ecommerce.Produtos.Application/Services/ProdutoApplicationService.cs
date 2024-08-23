using Ecommerce.Produtos.Domain.Dtos;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Application.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoApplicationService(IProdutoRepository repository)
        {
            _repository = repository;   
        }

        public ProdutoDto AdicionarProduto(ProdutoDto entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoDto DeletarProduto(ProdutoDto entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoDto EditarProduto(ProdutoDto entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoDto ObterProdutoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoDto> ObterTodosProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
