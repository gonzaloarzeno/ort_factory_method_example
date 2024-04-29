using FactoryMethodExample.Entities;
using FactoryMethodExample.PublicDLL;
using FactoryMethodExample.Shared;

namespace FactoryMethodExamplePublicDLL.Concretes;

public class TruckFactory : ITransportationFactory
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}