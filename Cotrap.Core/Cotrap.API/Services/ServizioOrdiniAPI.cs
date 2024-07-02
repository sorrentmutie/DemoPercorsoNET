using Cotrap.Core.Northwind.DTO;
using Cotrap.Data.Northwind.Models;
using Cotrap.Northwind;
using System.Linq.Expressions;

namespace Cotrap.API.Services;

public class ServizioOrdiniAPI : IDataService<Order, OrdineDTO, OrdineCreaDTO, int>
{
    public Task AddNew(OrdineCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddNewWithId(OrdineCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrdineDTO>?> GetAsync(Expression<Func<Order, bool>>? filter)
    {
        throw new NotImplementedException();
    }

    public Task<OrdineDTO?> GetAsyncById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task Update(OrdineDTO category)
    {
        throw new NotImplementedException();
    }
}
