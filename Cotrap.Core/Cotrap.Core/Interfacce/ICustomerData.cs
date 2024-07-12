using Cotrap.Core.Northwind.DTO;

namespace Cotrap.Core.Interfacce;


public interface ICustomerData
{
    public Task<ClienteDettagliato?> GetCustomerDetailById(string Id); 
}
