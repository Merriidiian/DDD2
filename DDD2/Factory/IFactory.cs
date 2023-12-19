namespace DDD2.Factory;

public interface IFactory
{
    Task<bool> CreateAggregates();
}