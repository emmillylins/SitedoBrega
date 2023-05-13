using UserClass.Entities;
using FluentValidation;

namespace UserClass.Services
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("Please enter the login.")
                .NotNull().WithMessage("Please enter the login.");

            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Please enter the password.")
                .NotNull().WithMessage("Please enter the password.");

        }
    }
}
