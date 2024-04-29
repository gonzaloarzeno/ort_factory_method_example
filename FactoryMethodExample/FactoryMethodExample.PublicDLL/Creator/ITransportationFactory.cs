using FactoryMethodExample.Shared;

namespace FactoryMethodExample.PublicDLL;

public interface ITransportationFactory
{
    ITransport CreateTransport();
}