using Cotrap.Core.Northwind.DTO;

namespace Cotrap.Core.Northwind.Interfaces;

public interface ICustomersNorthwindData
{
    Task<IEnumerable<ClienteDTO>?> GetClientiAsync();
}
