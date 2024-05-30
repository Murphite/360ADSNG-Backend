namespace _360AdsNG.Domain.Repositories;

public interface IUnitOfWork
{
    public Task<int> SaveChangesAsync();
}
