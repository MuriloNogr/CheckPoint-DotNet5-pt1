using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;

namespace Ecommerce.Produtos.Application.Services
{
    public class CategoriaApplicationService : ICategoriaApplicationService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaApplicationService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public CategoriaEntity? DeletarDadosCategoria(int id)
        {
            return _categoriaRepository.DeletarDados(id);
        }

        public CategoriaEntity? EditarDadosCategoria(CategoriaEntity entity)
        {
            return _categoriaRepository.EditarDados(entity);
        }

        public CategoriaEntity? ObterCategoriaPorId(int id)
        {
            return _categoriaRepository.ObterPorId(id);
        }

        public IEnumerable<CategoriaEntity> ObterTodasCategorias()
        {
            return _categoriaRepository.ObterTodos();
        }

        public CategoriaEntity? SalvarDadosCategoria(CategoriaEntity entity)
        {
            return _categoriaRepository.SalvarDados(entity);
        }
    }
}
