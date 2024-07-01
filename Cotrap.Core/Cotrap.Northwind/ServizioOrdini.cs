using Cotrap.Core.Interfacce;
using Cotrap.Core.Northwind.DTO;
using System.Linq.Expressions;

namespace Cotrap.Northwind;

//IDataService<TEntity, TDTO, TCreaDTO, Tkey> where TEntity : class, IEntity<Tkey>, new ()
public class ServizioOrdini : IDataService<Order, OrdineDTO, OrdineCreaDTO, int>
{
    private readonly IRepository<Order, int> repository;

    public ServizioOrdini(IRepository<Order, int> repository)
    {
        this.repository = repository;
    }

    public async Task AddNew(OrdineCreaDTO ordineDTO)
    {
        var ordine = new Order() { CustomerId = ordineDTO.CustomerId, OrderDate = ordineDTO.OrderDate };
        await repository.CreateAsync(ordine);
    }

    public async Task<int> AddNewWithId(OrdineCreaDTO ordineDto)
    {
        var ordine = new Order() { CustomerId = ordineDto.CustomerId, OrderDate = ordineDto.OrderDate };
        var id = await repository.CreateAsyncWithId(ordine);
        return id;
    }

    public async Task Delete(int Id)
    {
        await repository.DeleteAsync(Id);
    }

    public async Task<IEnumerable<OrdineDTO>?> GetAsync(Expression<Func<Order, bool>>? filter)
    {
        var orders = await repository.Filter(filter);
        if (orders is null) return null;
        
        var ordiniDto = new List<OrdineDTO>();
        foreach (var ord in orders)
        {
            if (ord is null) continue;

            ordiniDto.Add(new OrdineDTO() { Id = ord.Id, CustomerId = ord.CustomerId, OrderDate = ord.OrderDate });
        }

        return ordiniDto;
    }

    public async Task<OrdineDTO?> GetAsyncById(int Id)
    {
        var x = await repository.GetByIdAsync(Id);
        if (x is null) return null;

        return new OrdineDTO() { Id = x.Id, CustomerId = x.CustomerId, OrderDate = x.OrderDate };
    }

    public async Task Update(OrdineDTO ordineDto)
    {
        var ordine = new Order() { OrderDate = ordineDto.OrderDate, Id = ordineDto.Id, CustomerId = ordineDto.CustomerId };
        await repository.UpdateAsync(ordine);
    }
}
