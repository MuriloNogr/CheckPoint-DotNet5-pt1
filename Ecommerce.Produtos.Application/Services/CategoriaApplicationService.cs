using Ecommerce.Produtos.Domain.Dtos;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Application.Services
{
    public class CategoriaApplicationService : ICategoriaApplicationService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaApplicationService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public CategoriaDto AdicionarCategoria(CategoriaDto entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaDto DeletarCategoria(CategoriaDto entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaDto EditarCategoria(CategoriaDto entity)
        {
            throw new NotImplementedException();
        }

        public CategoriaDto ObterCategoriaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaDto> ObterTodasCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
