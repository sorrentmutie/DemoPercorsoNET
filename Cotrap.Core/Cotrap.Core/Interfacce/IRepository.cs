using System.Linq.Expressions;

namespace Cotrap.Core.Interfacce;

public interface IRepository<TEntity, TKey>
    where TEntity : class, IEntity<TKey>, new()
{
    IQueryable<TEntity> GetAll();
    Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>> ? filter = null,
        bool tracked = true);
    Task<TEntity?> GetByIdAsync(TKey id);
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TKey id);
    Task<TKey> CreateAsyncWithId(TEntity entity);
}
