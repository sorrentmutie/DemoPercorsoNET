using Cotrap.Core.Interfacce;
using System.Linq.Expressions;

namespace Cotrap.Northwind;

public class ServizioCustomer: IDataService<Customer, CustomerDTO, CustomerCreaDTO, string>
{
    private readonly IRepository<Customer, string> repository;

    public ServizioCustomer(IRepository<Customer, string> repository)
    {
        this.repository = repository;
    }

    public Task AddNew(CustomerCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task<string> AddNewWithId(CustomerCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerDTO>?> GetAsync(Expression<Func<Customer, bool>>? filter)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerDTO?> GetAsyncById(string Id)
    {
        throw new NotImplementedException();
    }

    public Task Update(CustomerDTO category)
    {
        throw new NotImplementedException();
    }
}
