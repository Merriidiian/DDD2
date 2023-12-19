using DDD2.Aggregates;

namespace DDD2.Repositories;

public class BuyerRepository : IRepository
{
    public async Task<Buyer> Get<Buyer>(Guid id)
    {
        throw new NotImplementedException();
    }
    
    public async Task<bool> Set<Buyer>(Buyer buyer)
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