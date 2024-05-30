

using _360AdsNG.Domain.Entities;

namespace _360AdsNG.Domain.Repositories;

public interface IRepository
{
    public Task Add<TEntity>(TEntity entity) where TEntity : class;
    public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
    public Task<TEntity> GetById<TEntity>(string id) where TEntity : class;
    public void Update<TEntity>(TEntity entity) where TEntity : class;
    public void Remove<TEntity>(TEntity entity)where TEntity : class;
}
