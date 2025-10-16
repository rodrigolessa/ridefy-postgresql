namespace Ridefy.Models;

public class Rider : AggregateRoot
{
    public const int NameMaxLength = 155;
    public const int DocumentNumberLength = 14;
    public const int MinValidAge = 18;
    public const int MaxValidAge = 120;
}