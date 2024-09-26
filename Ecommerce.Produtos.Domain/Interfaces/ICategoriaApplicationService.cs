using Ecommerce.Produtos.Domain.Entities;
using Ecommerce.Produtos.Domain.Interfaces.Dtos;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface ICategoriaApplicationService
    {
        IEnumerable<CategoriaEntity> ObterTodasCategorias();
        CategoriaEntity? ObterCategoriaPorId(int id);
        CategoriaEntity? SalvarDadosCategoria(ICategoriaDto entity);
        CategoriaEntity? EditarDadosCategoria(int id, ICategoriaDto entity);
        CategoriaEntity? DeletarDadosCategoria(int id);
    }
}