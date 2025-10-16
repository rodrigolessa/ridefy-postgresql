namespace Ridefy.Models;

public readonly struct MotorcycleId : IEquatable<MotorcycleId>
{
    public string Value { get; }

    private MotorcycleId(string value) => Value = value;

    public static MotorcycleId New() => new MotorcycleId(Ulid.NewUlid().ToString());
    public static MotorcycleId From(string value) => new MotorcycleId(value);

    public bool Equals(MotorcycleId other) => Value == other.Value;
    public override bool Equals(object? obj) => obj is MotorcycleId other && Equals(other);
    public override int GetHashCode() => Value.GetHashCode();
    public override string ToString() => Value;
}