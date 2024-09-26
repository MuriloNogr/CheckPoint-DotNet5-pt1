using Ecommerce.Produtos.Domain.Interfaces.Dtos;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Produtos.Application.Dtos
{
    public class CategoriaDto : ICategoriaDto
    {
        //[Required(ErrorMessage = "O campo nome nao pode ser vazio")]
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public void Validate()
        {
            //if (string.IsNullOrEmpty(Nome))
            //    throw new Exception("O campo nome nao pode ser vazio");

            //if(Nome.Length < 5)
            //    throw new Exception("O campo nome deve ter no minimo 5 caracters");

            //if (Nome.Length < 5 && Descricao.Length < 10)
            //    throw new Exception("O campo nome deve ter no minimo 5 caracters");

            //FluentValidation
            var validateResult = new CategoriaDtoValidation().Validate(this);

            if (!validateResult.IsValid)
                throw new Exception(string.Join(" e ", validateResult.Errors.Select(x => x.ErrorMessage)));
        }
    }

    internal class CategoriaDtoValidation : AbstractValidator<CategoriaDto>
    {
        public CategoriaDtoValidation()
        {
            RuleFor(x => x.Nome)
                .MinimumLength(5).WithMessage(x => $"O campo {nameof(x.Nome)} deve ter no minimo 5 caracters")
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Nome)} nao pode ser vazio");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage(x => $"O campo {nameof(x.Descricao)} nao pode ser vazio");

        }
    }
}
