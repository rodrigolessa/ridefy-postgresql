namespace Ridefy.Events;

public class MotorcycleRegistered : MyBaseEvent
{
    public string ExternalId { get; private set; }
    public int Year { get; private set; }
    public string Model { get; private set; }
    public string Plate { get; private set; }
    
    public MotorcycleRegistered(
        string idempotencyKey, string aggregateId, TimeProvider timeProvider,
        string externalId, int year, string model, string plate) 
        : base(idempotencyKey, aggregateId, timeProvider)
    {
        ExternalId = externalId;
        Year = year;
        Model = model;
        Plate = plate;
    }
}