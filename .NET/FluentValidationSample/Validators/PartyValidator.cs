using FluentValidation;
using FluentValidationSample.Models;

namespace FluentValidationSample.Validators
{
    public class PartyValidator : AbstractValidator<Party>
    {
        public PartyValidator()
        {
            RuleForEach(party => party.Guests)
                .SetValidator(new PersonValidator());
        }
    }
}