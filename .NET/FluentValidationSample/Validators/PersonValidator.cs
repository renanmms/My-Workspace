using FluentValidation;
using FluentValidation.Validators;
using FluentValidationSample.Models;

namespace FluentValidationSample.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Name is required!");

            RuleFor(p => p.Age)
                .NotEmpty()
                .NotNull()
                .WithMessage("Age is required!");

            RuleFor(p => p.Age)
                .GreaterThanOrEqualTo(18)
                .WithMessage("Your age must be greater or equal to 18!");

        }
    }
}