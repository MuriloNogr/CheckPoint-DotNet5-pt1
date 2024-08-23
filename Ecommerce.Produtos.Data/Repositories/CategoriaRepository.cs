using Ecommerce.Produtos.Data.AppContext;
using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppplicationContext _context;

        public CategoriaRepository(AppplicationContext context)
        {
            _context = context;
        }
        public CategoriaEntity Adicionar(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity Deletar(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity Editar(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
