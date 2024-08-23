using Ecommerce.Produtos.Data.AppContext;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppplicationContext _context;

        public ProdutoRepository(AppplicationContext context)
        {
            _context = context;
        }

        public ProdutoEntity Adicionar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity Deletar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity Editar(ProdutoEntity entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
