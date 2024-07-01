using Cotrap.Core.Northwind.DTO;
using Cotrap.Core.Northwind.Interfaces;
using Cotrap.Data.Northwind.Models;
using Microsoft.EntityFrameworkCore;
using Cotrap.Data.ExtensionsMethods;

namespace Cotrap.Data.Services;

public class CustomersNorthwindSQlServerData : ICustomersNorthwindData
{
    private readonly NorthwindContext context;

    public CustomersNorthwindSQlServerData(NorthwindContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<ClienteDTO>?> GetClientiAsync()
    {
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var data =  (await context.Customers.Include(c => c.Orders)
            .ThenInclude( o => o.OrderDetails)
            .ToListAsync()).ToClienteDTO();
        context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return data;
    }
}
