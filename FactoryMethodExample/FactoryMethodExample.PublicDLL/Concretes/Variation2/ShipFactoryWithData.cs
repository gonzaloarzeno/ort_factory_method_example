using FactoryMethodExample.DTO;
using FactoryMethodExample.Entities;
using FactoryMethodExample.PublicDLL.Variation2;
using FactoryMethodExample.Shared;

namespace FactoryMethodExamplePublicDLL.Concretes.Variation2;

public class ShipFactoryWithData : ITransportationFactoryWithData<ShipData>
{
    public ITransport CreateTransport(ShipData data)
    {
        return new Ship()
        {
            CaptainName = data.Captain,
            ContainersQuantity = data.ContainersCount
        };
    }
}