using FactoryMethodExample.Shared;

namespace FactoryMethodExample.Entities;

public class Truck : ITransport
{
    public string Driver { get; set; }
    public string LicensePlate { get; set; }
    
    public void Deliver()
    {
        Console.WriteLine("Deliver by land in a box");
    }
    
    public void DeliverVariation2()
    {
        Console.WriteLine($"Deliver by {Driver} in truck with license plate: {LicensePlate}");
    }
}