using DDD2.Aggregates;

namespace DDD2.Repositories;

public class OrderRepository : IRepository
{
    public async Task<Order> Get<Order>(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Set<Order>(Order order)
    {
        try
        {   
            //INSERT in DB
            // "Buyer.AddDb"
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}