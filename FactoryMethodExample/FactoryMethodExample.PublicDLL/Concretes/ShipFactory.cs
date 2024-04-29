using FactoryMethodExample.Entities;
using FactoryMethodExample.PublicDLL;
using FactoryMethodExample.Shared;

namespace FactoryMethodExamplePublicDLL.Concretes;

public class ShipFactory : ITransportationFactory
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}