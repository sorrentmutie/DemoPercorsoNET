using Cotrap.Core.Interfacce;
using Cotrap.Core.Northwind.DTO;
using Cotrap.Core.Northwind.Interfaces;
using Cotrap.Data.Northwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Cotrap.Data.Services;

public class GenericNorthwindData<T, U> : IGenericNorthwindData<T, U> where T : class, IEntity<U>
{
    private readonly NorthwindContext northwindContext;
    private DbSet<T>? items;


    public GenericNorthwindData(NorthwindContext northwindContext)
    {
        this.northwindContext = northwindContext;
        items = northwindContext.Set<T>();
    }


    public async Task AddItemAsync(T newItem)
    {
        items!.Add(newItem);
        await northwindContext.SaveChangesAsync();
    }

    public async Task<T?> GetItemAsync(U id)
    {
        return await items!.FindAsync(id);
    }

    public IQueryable<T>? GetItems()
    {
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var data = items;
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return data;
    }

    public async Task<IEnumerable<T>?> GetItemsAsync()
    {
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var data =  items is not null ? await items.ToListAsync(): null;
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return data;
    }

    public async Task UpdateItemAsync(T updatedItem)
    {
        var itemDb = await items!.FindAsync(updatedItem.Id);

        if (itemDb is not null)
        {
            northwindContext.Entry(itemDb).State = EntityState.Detached;
            northwindContext.Entry(updatedItem).State = EntityState.Modified;
            await northwindContext.SaveChangesAsync();
        }
    }
}
