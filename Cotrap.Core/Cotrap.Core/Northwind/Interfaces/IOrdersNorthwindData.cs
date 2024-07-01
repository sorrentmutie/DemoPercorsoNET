using Cotrap.Core.Northwind.DTO;

namespace Cotrap.Core.Northwind.Interfaces;

public interface IOrdersNorthwindData
{
    Task<OrdineDTO?> EstraiOrdine(int orderId);
}
