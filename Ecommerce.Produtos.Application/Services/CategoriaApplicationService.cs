using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces;
using Ecommerce.Produtos.Domain.Interfaces.Dtos;

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

        public CategoriaEntity? EditarDadosCategoria(int id, ICategoriaDto entity)
        {
            entity.Validate();

            return _categoriaRepository.EditarDados(new CategoriaEntity { 
                Id = id,
                Nome = entity.Nome,
                Descricao = entity.Descricao,
            });
        }

        public CategoriaEntity? ObterCategoriaPorId(int id)
        {
            return _categoriaRepository.ObterPorId(id);
        }

        public IEnumerable<CategoriaEntity> ObterTodasCategorias()
        {
            return _categoriaRepository.ObterTodos();
        }

        public CategoriaEntity? SalvarDadosCategoria(ICategoriaDto entity)
        {
            entity.Validate();

            return _categoriaRepository.SalvarDados(new CategoriaEntity
            {
                Nome = entity.Nome,
                Descricao = entity.Descricao,
            });
        }
    }
}
