using AutoMapper;
using Cotrap.Core.Northwind.DTO;
using Cotrap.Data.Northwind.Models;
using Cotrap.Northwind;
using System.Linq.Expressions;

namespace Cotrap.API.Services;

public class ServizioCustomerAPI : IDataService<Customer, CustomerDTO, CustomerCreaDTO, string>
{
    private readonly IRepository<Customer, string> repository;
    private readonly IMapper mapper;

    public ServizioCustomerAPI(IRepository<Customer, string> repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public Task AddNew(CustomerCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public async Task<string> AddNewWithId(CustomerCreaDTO newCustomer)
    {
       var customer = mapper.Map<Customer>(newCustomer);
       return await  repository.CreateAsyncWithId(customer);
    }

    public async Task Delete(string Id)
    {
        await repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<CustomerDTO>?> GetAsync(Expression<Func<Customer, bool>>? filter)
    {
        var customers = await repository.Filter(filter);
        if(customers is null) return null;
        return customers.Select(c => mapper.Map<CustomerDTO>(c));
    }

    public async Task<CustomerDTO?> GetAsyncById(string Id)
    {
        var customer = await repository.GetByIdAsync(Id);
        if(customer is null) return null;
        return mapper.Map<CustomerDTO>(customer);
    }

    public async Task Update(CustomerDTO category)
    {
        await repository.UpdateAsync(mapper.Map<Customer>(category));
    }
}
