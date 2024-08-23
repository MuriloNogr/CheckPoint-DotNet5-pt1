using Ecommerce.Produtos.Domain.Dtos;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface ICategoriaApplicationService
    {
        CategoriaDto ObterCategoriaPorId(int id);
        IEnumerable<CategoriaDto> ObterTodasCategorias();
        CategoriaDto AdicionarCategoria(CategoriaDto entity);
        CategoriaDto EditarCategoria(CategoriaDto entity);
        CategoriaDto DeletarCategoria(CategoriaDto entity);
    }
}
