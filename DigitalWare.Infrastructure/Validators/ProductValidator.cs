using DigitalWare.Core.DTOs.Product;
using FluentValidation;

namespace DigitalWare.Infrastructure.Validators
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(dto => dto.Name)
                .NotNull()
                .MinimumLength(4);
        }
    }
}