
using Cotrap.API.ExtentionMethods;

namespace Cotrap.API.Services;

public class ServizioDatiCliente : ICustomerData
{
    private readonly NorthwindContext context;

    public ServizioDatiCliente(NorthwindContext context)
    {
        this.context = context;
    }
    public async Task<ClienteDettagliato?> GetCustomerDetailById(string Id)
    {
        var customer = await context.Customers.Include(c => c.Orders)
                            .ThenInclude(o => o.OrderDetails)
                            .ThenInclude(od => od.Product)                            
                            .FirstOrDefaultAsync(x => x.Id == Id);

        var products = await context.OrderDetails.Include(od => od.Product)
            .ThenInclude(p => p.Supplier)
            .Select(x => new ProdottoDTO { Id = x.ProductId, Nome = x.Product.ProductName, Fornitore = x.Product.Supplier.CompanyName })
            .Distinct()
            .ToListAsync();

        if (customer is not null)
        {
            var cliente = customer.ToClienteDettagliato();
            cliente.ListaProdotti = products;
            return cliente;
        }
        else 
        { 
            return null; 
        }
    }
}
