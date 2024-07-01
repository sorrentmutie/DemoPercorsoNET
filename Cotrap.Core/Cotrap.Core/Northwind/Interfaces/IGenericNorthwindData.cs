using Cotrap.Core.Interfacce;
using Cotrap.Core.Northwind.DTO;

namespace Cotrap.Core.Northwind.Interfaces;

public interface IGenericNorthwindData<T,U> where T : class, IEntity<U>
{
    Task<IEnumerable<T>?> GetItemsAsync();
    Task<T?> GetItemAsync(U id);
    Task AddItemAsync(T newItem);
    Task UpdateItemAsync(T updatedItem);
    IQueryable<T>? GetItems();
}
