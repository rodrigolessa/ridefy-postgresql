namespace Ridefy.Models;

public class Motorcycle : AggregateRoot
{
    public const int ExternalIdMaxLength = 50;
    public const int PlateMaxLength = 9;
    public const int ModelMaxLength = 150;
    public const int MinAgeAcceptedInYears = 20;
    
    public MotorcycleId Id { get; private set; }
    public string ExternalId { get; private set; }
    public int Year { get; private set; }
    public string Model { get; private set; }
    public string Plate { get; private set; }

}