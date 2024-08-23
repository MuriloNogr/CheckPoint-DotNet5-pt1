using Ecommerce.Produtos.Domain.Dtos.Common;
using FluentValidation;

namespace Ecommerce.Produtos.Domain.Dtos
{
    public class CategoriaDto: CommonDto
    {
        public void Validar()
        {
            var validateResult = new CategoriaDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new ArgumentException(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class CategoriaDtoValidation : AbstractValidator<CategoriaDto>
    {
        public CategoriaDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O Campo {nameof(x.Nome)} deve ter no minimo 5 caracteres")
                .NotEmpty().WithMessage(x => $"O Campo {nameof(x.Nome)} não pode ser vazio");
        }
    }
}
