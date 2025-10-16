namespace Ridefy.Infrastructure.Cqrs.Commands;

public abstract class MyBaseCommand : IBaseCommand
{
    public string AggregateId { get; set; }
    public string IdempotencyKey { get; set; }
    public string SessionKey { get; set; }
    public string RouteKey { get; set; }
    public string? ApplicationKey { get; set; }
    public string? UserEmail { get; set; }
    public DateTime Timestamp { get; set; }

    protected MyBaseCommand(
        string aggregateId,
        string? idempotencyKey,
        string sessionKey,
        string routeKey,
        string? applicationKey,
        string? userEmail = null!)
    {
        AggregateId = aggregateId;
        SessionKey = sessionKey;
        RouteKey =  routeKey;
        ApplicationKey = applicationKey;
        UserEmail = userEmail;
        Timestamp = DateTime.UtcNow;
        
        SetIdempotencyKey(idempotencyKey); }

    private void SetIdempotencyKey(string? idempotencyKey)
    {
        if (string.IsNullOrWhiteSpace(idempotencyKey))
        {
            IdempotencyKey = Ulid.NewUlid().ToString();
        }
    }
}