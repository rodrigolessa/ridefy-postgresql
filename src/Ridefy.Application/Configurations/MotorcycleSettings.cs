using System.Diagnostics.CodeAnalysis;
using Ridefy.Models;

namespace Ridefy.Application.Configurations;

[ExcludeFromCodeCoverage]
public class MotorcycleSettings
{
    public const string SectionName = "MotorcycleSettings";
    public int MinAgeAcceptedInYears { get; set; } = Motorcycle.MinAgeAcceptedInYears;
}