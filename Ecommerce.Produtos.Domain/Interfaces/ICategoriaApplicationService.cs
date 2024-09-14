using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface ICategoriaApplicationService
    {
        IEnumerable<CategoriaEntity> ObterTodasCategorias();
        CategoriaEntity? ObterCategoriaPorId(int id);
        CategoriaEntity? SalvarDadosCategoria(CategoriaEntity entity);
        CategoriaEntity? EditarDadosCategoria(CategoriaEntity entity);
        CategoriaEntity? DeletarDadosCategoria(int id);
    }
}