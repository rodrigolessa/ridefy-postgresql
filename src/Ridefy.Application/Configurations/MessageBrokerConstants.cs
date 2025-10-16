namespace Ridefy.Application.Configurations;

public class MessageBrokerConstants
{
    public const string ExchangeForCommands = "ridefy.broker";
    public const string ExchangeForEvents = "ridefy.public.broker";
    public const string RegistrationRoute = "ridefy.new"; // Registration of motorcycles and riders.

    public const string
        RentalRoute =
            "ridefy.rental"; // Rental and return of a motorcycle. TODO: How to avoid concurrent commands for rental and deletion of a motorcycle?

    public const string
        OrderRoute =
            "ridefy.order"; // Creating an order and requesting a delivery. TODO: How to avoid simultaneous commands to delete a motorcycle when a delivery is also requested? 

    public const string EventRoute = "ridefy.public.event"; // When a motorcycle was created.
}