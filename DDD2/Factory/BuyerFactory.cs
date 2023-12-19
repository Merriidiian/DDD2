using DDD2.Aggregates;
using DDD2.Repositories;

namespace DDD2.Factory;


public class BuyerFactory : IFactory
{
    private readonly BuyerRepository _repository;

    public BuyerFactory(BuyerRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> CreateAggregates()
    {
        try
        {
            var newBuyer = new Buyer
            {
                Client = await CreateClient(),
                MethodBuy = MethodBuy.Card,
                TypeCard = TypeCard.MIR
            };
            await _repository.Set(newBuyer);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
    }

    public async Task<Client> CreateClient()
    {
        return new Client
        {
            Id = new Guid(),
            Address = "Address",
            Name = "Name",
            Surname = "Surname"
        };
    }
}