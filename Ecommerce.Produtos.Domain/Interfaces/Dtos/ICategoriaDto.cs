namespace Ecommerce.Produtos.Domain.Interfaces.Dtos
{
    public interface ICategoriaDto
    {
        string Nome { get; set; }
        string Descricao { get; set; }
        void Validate();
    }
}
