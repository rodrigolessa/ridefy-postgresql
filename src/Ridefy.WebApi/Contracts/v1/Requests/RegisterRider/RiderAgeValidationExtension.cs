using FluentValidation;

namespace Ridefy.WebApi.Contracts.v1.Requests.RegisterRider;

public static class RiderAgeValidationExtension
{
    public static IRuleBuilderOptions<T, DateTime> MustBeAValidAge<T>(
        this IRuleBuilder<T, DateTime> ruleBuilder, TimeProvider timeProvider, int minAge, int maxAge)
    {
        return ruleBuilder.Must(dob =>
            {
                var today = timeProvider.GetUtcNow().Date;
                var age = today.Year - dob.Year;
                if (today < dob.AddYears(age)) age--;
                return age is >= 18 and <= 120;
            })
            .WithMessage($"Age must be between {minAge} and {maxAge} years old.");
    }
}