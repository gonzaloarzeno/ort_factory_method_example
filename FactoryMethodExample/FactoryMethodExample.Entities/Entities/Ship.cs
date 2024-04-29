using FactoryMethodExample.Shared;

namespace FactoryMethodExample.Entities;

public class Ship : ITransport
{
    public string CaptainName { get; set; }
    public int ContainersQuantity { get; set; }
    
    
    public void Deliver()
    {
        Console.WriteLine("Deliver by sea in a container");
    }

    public void DeliverVariation2()
    {
        Console.WriteLine($"Deliver by sea with captain: {CaptainName} in {ContainersQuantity} containers");
    }
}