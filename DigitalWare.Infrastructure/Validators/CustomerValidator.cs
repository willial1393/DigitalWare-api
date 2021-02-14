using DigitalWare.Core.DTOs;
using FluentValidation;

namespace DigitalWare.Infrastructure.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(dto => dto.Birthday)
                .NotNull();
        }
    }
}