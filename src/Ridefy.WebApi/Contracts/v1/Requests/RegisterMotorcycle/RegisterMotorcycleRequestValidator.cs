using FluentValidation;
using Ridefy.Application.Configurations;
using Ridefy.Models;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterMotorcycle;

public class RegisterMotorcycleRequestValidator : AbstractValidator<RegisterMotorcycleRequest>
{
    public RegisterMotorcycleRequestValidator(MotorcycleSettings settings, TimeProvider timeProvider)
    {
        var currentYear = timeProvider.GetUtcNow().Year;
        
        RuleFor(x => x.ExternalId)
            .NotEmpty()
            .MaximumLength(Motorcycle.ExternalIdMaxLength);
        RuleFor(x => x.Model)
            .NotEmpty()
            .MaximumLength(Motorcycle.ModelMaxLength);        
        RuleFor(x => x.Plate)
            .NotEmpty()
            .MaximumLength(Motorcycle.PlateMaxLength);
        RuleFor(x => x.Year)
            .InclusiveBetween(currentYear - settings.MinAgeAcceptedInYears, currentYear);
    }
}