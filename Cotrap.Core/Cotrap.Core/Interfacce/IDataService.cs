using Cotrap.Core.Interfacce;
using System.Linq.Expressions;

namespace Cotrap.Northwind
{
    public interface IDataService<TEntity, TDTO, TCreaDTO, Tkey> where TEntity : class, IEntity<Tkey>, new()
    {
        Task<IEnumerable<TDTO>?> GetAsync(Expression<Func<TEntity, bool>>? filter);
        Task AddNew (TCreaDTO Item);
        Task Update(TDTO Item);
        Task Delete(Tkey Id);
        Task<Tkey> AddNewWithId(TCreaDTO Item);
        Task<TDTO?> GetAsyncById(Tkey Id);
    }
}