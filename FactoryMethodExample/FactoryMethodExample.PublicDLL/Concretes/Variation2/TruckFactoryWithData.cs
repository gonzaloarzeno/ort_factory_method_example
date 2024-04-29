using FactoryMethodExample.DTO;
using FactoryMethodExample.Entities;
using FactoryMethodExample.PublicDLL.Variation2;
using FactoryMethodExample.Shared;

namespace FactoryMethodExamplePublicDLL.Concretes.Variation2;

public class TruckFactoryWithData : ITransportationFactoryWithData<TruckData>
{
    public ITransport CreateTransport(TruckData data)
    {
        return new Truck()
        {
            Driver = data.DriverName,
            LicensePlate = data.TruckPlate
        };
    }
}