

using Cotrap.Core.Northwind.DTO;
using Cotrap.Data.Northwind.Models;

namespace Cotrap.Data.ExtensionsMethods;

public static class NorthwindExtensions
{
    public static List<ClienteDTO> ToClienteDTO( 
        this List<Customer> customers)
    {
        return customers.Select(c => new ClienteDTO
        {
            Id = c.CustomerId,
            Contatto = c.ContactName,
            IndirizzoCompleto =
            $"{c.Address} {c.City} {c.Region} {c.PostalCode} {c.Country}",
            Telefono = c.Phone,
            Ordini = c.Orders.Count,
            TotaleOrdini = 
              c.Orders.Sum(o => o.OrderDetails.Sum(od => od.Quantity * od.UnitPrice))
        }).ToList();
    }
}
