using Cotrap.Core.Northwind.DTO;
using Cotrap.Core.Northwind.Interfaces;
using Cotrap.Data.Northwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Cotrap.Data.Services;

public class OrdersNorthwindSQlServerData : IOrdersNorthwindData
{
    private readonly NorthwindContext northwindContext;

    public OrdersNorthwindSQlServerData(NorthwindContext northwindContext)
    {
        this.northwindContext = northwindContext;
    }

    public async Task<OrdineDTO?> EstraiOrdine(int orderId)
    {
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var order = await northwindContext.Orders
            .Include(o => o.OrderDetails)
            .ThenInclude(od => od.Product)
            .FirstOrDefaultAsync(y => y.OrderId == orderId);

        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

        if (order == null) return null;

        return new OrdineDTO
        {
            CustomerId = order.CustomerId,
            Id = order.OrderId,
            OrderDate = order.OrderDate,
            Voci = order.OrderDetails.Select(od => new VoceOrdineDTO
            {
                OrderId = od.OrderId,
                PrezzoUnitario = od.UnitPrice,
                Quantità = od.Quantity,
                NomeProdotto = od.Product.ProductName

            }).ToList()
        };
    }
}
