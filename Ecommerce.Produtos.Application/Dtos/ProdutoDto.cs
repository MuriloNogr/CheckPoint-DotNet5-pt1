using Ecommerce.Produtos.Domain.Interfaces.Dtos;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Produtos.Application.Dtos
{
    public class ProdutoDto : IProdutoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public void Validate()
        {
            var validateResult = new ProdutoDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class ProdutoDtoValidation : AbstractValidator<ProdutoDto>
    {
        public ProdutoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} deve ter no mínimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} não pode ser vazio");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Descricao)} não pode ser vazio");

            RuleFor(x => x.Quantidade)
                .GreaterThanOrEqualTo(0).WithMessage(x => $"O campo {nameof(x.Quantidade)} deve ser maior ou igual a zero");
        }
    }
}
