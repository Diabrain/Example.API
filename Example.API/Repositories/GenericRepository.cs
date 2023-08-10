using Example.API.Context;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Repositories;

public class GenericRepository<TKey, TEntity, TDbContext> : IGenericRepository<TKey, TEntity, TDbContext>
     where TDbContext : DbContext where TEntity : class
{
    private readonly DbContext _context;
    protected readonly DbSet<TEntity> _entities;
    public GenericRepository(TDbContext context)
    {
        _context = context;
        _entities = _context.Set<TEntity>();
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await _entities.ToListAsync();

    }
    public async Task<TEntity> GetById(TKey key)
    {
        var entity = await _entities.FindAsync(key);
        if (entity == null)
        {
            throw new Exception($"{nameof(TEntity)}");
        }
        return entity;
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        _entities.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        _entities.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task Delete(TEntity entity)
    {
        _entities.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
