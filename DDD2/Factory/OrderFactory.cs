using DDD2.Aggregates;
using DDD2.Repositories;

namespace DDD2.Factory;

public class OrderFactory : IFactory
{
    private readonly OrderRepository _repository;

    public OrderFactory(OrderRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> CreateAggregates()
    {
        try
        {
            var newOrder = new Order
            {
                DetailsOrder = await CreateDetailsOrder(),
                Address = "Address",
                Products = new []{"Beer"},
                Status = Status.OK
            };
            await _repository.Set(newOrder);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
    }

    public async Task<DetailsOrder> CreateDetailsOrder()
    {
        return new DetailsOrder
        {
            Id = new Guid(),
            Sum = 1,
            DateTime = DateTime.Now
        };
    }
}