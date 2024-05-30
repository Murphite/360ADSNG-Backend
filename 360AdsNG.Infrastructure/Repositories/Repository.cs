using _360AdsNG.Domain.Entities;
using _360AdsNG.Domain.Repositories;
using _360AdsNG.Infrastructure.Persistence;

namespace _360AdsNG.Infrastructure.Repositories;

public class Repository : IRepository
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public async Task Add<TEntity>(TEntity entity) where TEntity : class
    {
        await _context.Set<TEntity>().AddAsync(entity);
    }

    public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
    {
        return _context.Set<TEntity>();
    }

    public async Task<TEntity?> GetById<TEntity>(string id) where TEntity : class
    {
        return await _context.Set<TEntity>().FindAsync(id) ?? null;
    }

    public void Remove<TEntity>(TEntity entity) where TEntity : class
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public void Update<TEntity>(TEntity entity) where TEntity : class
    {
        _context.Set<TEntity>().Update(entity);
    }
}
