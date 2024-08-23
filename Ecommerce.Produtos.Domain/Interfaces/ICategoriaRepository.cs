using Ecommerce.Produtos.Domain.Entities;

namespace Ecommerce.Produtos.Domain.Interfaces
{
    public interface ICategoriaRepository
    {
        CategoriaEntity ObterPorId(int id);
        IEnumerable<CategoriaEntity> ObterTodos();
        CategoriaEntity Adicionar(CategoriaEntity entity);
        CategoriaEntity Editar(CategoriaEntity entity);
        CategoriaEntity Deletar(CategoriaEntity entity);
    }
}
