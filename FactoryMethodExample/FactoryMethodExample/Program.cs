using FactoryMethodExample.DTO;
using FactoryMethodExample.Shared;
using FactoryMethodExamplePublicDLL.Concretes;
using FactoryMethodExamplePublicDLL.Concretes.Optional;
using FactoryMethodExamplePublicDLL.Concretes.Variation2;

ShipFactory shipFactory = new ShipFactory();
TruckFactory truckFactory = new TruckFactory();
ITransport ship = shipFactory.CreateTransport();
ITransport truck = truckFactory.CreateTransport();

Console.WriteLine("---Factory method---");
ship.Deliver();
truck.Deliver();

//Variation1
Console.WriteLine("---Variant 1---");
ITransport shipVariant = GenericTransportFactory.CreateTransport(TransportType.Ship);
shipVariant.Deliver();

//Variation2
ShipData shipData = new ShipData()
{
    Captain = "Jack Sparrow",
    ContainersCount = 10
};

TruckData truckData = new TruckData()
{
    DriverName = "Max Verstappen",
    TruckPlate = "AAA111"
};

ShipFactoryWithData shipFactoryWithData = new ShipFactoryWithData();
TruckFactoryWithData truckFactoryWithData= new TruckFactoryWithData();
ITransport shipVariant2 = shipFactoryWithData.CreateTransport(shipData);
ITransport truckVariant2 = truckFactoryWithData.CreateTransport(truckData);
Console.WriteLine("---Variant 2---");
shipVariant2.DeliverVariation2();
truckVariant2.DeliverVariation2();

