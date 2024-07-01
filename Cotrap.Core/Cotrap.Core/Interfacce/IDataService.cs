using Cotrap.Core.Interfacce;
using System.Linq.Expressions;

namespace Cotrap.Northwind
{
    public interface IDataService<TEntity, TDTO, TCreaDTO, Tkey> where TEntity : class, IEntity<Tkey>, new()
    {
        Task<IEnumerable<TDTO>?> GetAsync(Expression<Func<TEntity, bool>>? filter);
        Task AddNew (TCreaDTO category);
        Task Update(TDTO category);
        Task Delete(Tkey Id);
        Task<Tkey> AddNewWithId(TCreaDTO category);
        Task<TDTO?> GetAsyncById(Tkey Id);
    }
}