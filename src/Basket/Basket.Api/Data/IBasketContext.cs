using StackExchange.Redis;

namespace Basket.Api.Data
{
    public interface IBasketContext
    {
        IDatabase Redis { get; }
    }
}