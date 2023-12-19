namespace DDD2.Repositories;

public interface IRepository
{
    Task<T> Get<T>(Guid id);
    Task<bool> Set<T>(T model);
}