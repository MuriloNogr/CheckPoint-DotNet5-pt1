using Ecommerce.Produtos.Domain.Dtos.Common;
using FluentValidation;

namespace Ecommerce.Produtos.Domain.Dtos
{
    public class ProdutoDto: CommonDto
    {
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }

        public void Validar()
        {
            var validateResult = new ProdutoDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }

    }

    internal class ProdutoDtoValidation: AbstractValidator<ProdutoDto>
    {
        public ProdutoDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(3).WithMessage(x => $"O Campo {nameof(x.Nome)} deve ter no minimo 3 caracteres")
                .NotEmpty().WithMessage(x => $"O Campo {nameof(x.Nome)} não pode ser vazio");

            RuleFor(x => x.Quantidade)
                .GreaterThan(0).WithMessage(x => $"O Campo {nameof(x.Quantidade)} deve conter pelo menos um item");

            RuleFor(x => x.CategoriaId)
                .GreaterThan(0).WithMessage(x => $"O Campo {nameof(x.CategoriaId)} deve conter o valor de uma categoria");

        }
    }
}
