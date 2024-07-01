using Cotrap.Core.Interfacce;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Cotrap.Data.Models;

public class EFRepository<TEntity, TKey>
    : IRepository<TEntity, TKey>
    where TEntity : class, IEntity<TKey>, new()
{
    private readonly DbContext dbContext;
    private readonly DbSet<TEntity> dbSet;

    public EFRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
        dbSet = dbContext.Set<TEntity>();
    }

    public async Task CreateAsync(TEntity entity)
    {
        dbSet.Add(entity);
        await dbContext.SaveChangesAsync();
        dbContext.Entry(entity).State = EntityState.Detached;
    }

    public async Task DeleteAsync(TKey id)
    {
        var entity = new TEntity { Id = id };
        dbSet.Remove(entity);
        await dbContext.SaveChangesAsync();
        dbContext.Entry(entity).State = EntityState.Detached;
    }

    public async Task<IEnumerable<TEntity>> Filter(Expression<Func<TEntity, bool>>? filter = null, bool tracked = true)
    {
        var query = dbSet.AsQueryable();
        if (filter is not null)
        {
            query = query.Where(filter);
        }
        if (!tracked)
        {
            query = query.AsNoTracking();
        }
        return await query.ToListAsync();
    }

    public IQueryable<TEntity> GetAll()
    {
        return dbSet.AsNoTracking();
    }

    public async Task<TEntity?> GetByIdAsync(TKey id)
    {
        var entity = await dbSet.FindAsync(id);
        if (entity is null) return null;
        dbContext.Entry(entity).State = EntityState.Detached;
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        dbSet.Update(entity);
        await dbContext.SaveChangesAsync();
        dbContext.Entry(entity).State = EntityState.Detached;
    }
}
