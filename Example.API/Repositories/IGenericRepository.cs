namespace Example.API.Repositories;

public interface IGenericRepository<TKey, TEntity, TDbContext>
{
    Task<List<TEntity>> GetAll();
    Task<TEntity> GetById(TKey key);
    Task<TEntity> Create(TEntity entity);
    Task<TEntity> Update(TEntity entity);
    Task Delete(TEntity entity);
}
