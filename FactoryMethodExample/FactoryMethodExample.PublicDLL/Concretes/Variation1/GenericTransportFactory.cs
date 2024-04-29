using FactoryMethodExample.Entities;
using FactoryMethodExample.Shared;

namespace FactoryMethodExamplePublicDLL.Concretes.Optional;

public static class GenericTransportFactory
{
    public static ITransport CreateTransport(TransportType transportType)
    {
        switch (transportType)
        {
            case TransportType.Ship:
                return new Ship();
            case TransportType.Truck:
                return new Truck();
            default:
                throw new Exception("Not implemented transport");
        }
    }
}