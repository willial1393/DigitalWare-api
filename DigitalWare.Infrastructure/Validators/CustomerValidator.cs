using DigitalWare.Core.DTOs.Customer;
using FluentValidation;

namespace DigitalWare.Infrastructure.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(dto => dto.Birthday).NotNull();
            RuleFor(dto => dto.DocumentNumber).NotNull();
            RuleFor(dto => dto.FirstName).NotNull();
            RuleFor(dto => dto.LastName).NotNull();
        }
    }
}