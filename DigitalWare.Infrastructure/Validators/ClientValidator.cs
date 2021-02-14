using DigitalWare.Core.DTOs;
using FluentValidation;

namespace DigitalWare.Infrastructure.Validators
{
    public class ClientValidator : AbstractValidator<ClientDto>
    {
        public ClientValidator()
        {
            RuleFor(dto => dto.Birthday)
                .NotNull();
        }
    }
}