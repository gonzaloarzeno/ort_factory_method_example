using FactoryMethodExample.Entities;
using FactoryMethodExample.Shared;

namespace FactoryMethodExample.PublicDLL.Variation2;

public interface ITransportationFactoryWithData<T>
{
    ITransport CreateTransport(T data);
}