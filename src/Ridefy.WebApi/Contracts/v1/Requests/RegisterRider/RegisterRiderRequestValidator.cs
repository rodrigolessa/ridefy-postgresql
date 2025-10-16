using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Ridefy.Models;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterRider;

public class RegisterRiderRequestValidator : AbstractValidator<RegisterRiderRequest<ObjectResult>>
{
    public RegisterRiderRequestValidator(TimeProvider timeProvider)
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required.")
            .MaximumLength(Rider.NameMaxLength);

        RuleFor(x => x.DocumentNumber)
            .NotEmpty()
            .Length(Rider.DocumentNumberLength)
            .WithMessage("Invalid document number.");

        RuleFor(x => x.DateOfBirth)
            .MustBeAValidAge(timeProvider, Rider.MinValidAge, Rider.MaxValidAge);
    }
}