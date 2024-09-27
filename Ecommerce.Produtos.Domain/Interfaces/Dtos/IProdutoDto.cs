namespace Ecommerce.Produtos.Domain.Interfaces.Dtos
{
    public interface IProdutoDto
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Descricao { get; set; }
        int Quantidade { get; set; }
        int CategoriaId { get; set; }
        void Validate();
    }
}
