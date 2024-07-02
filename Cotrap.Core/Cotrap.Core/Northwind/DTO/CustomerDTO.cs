using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Northwind.DTO;

public class CustomerDTO
{
    public string Id { get; set; } = string.Empty;

    public string? Nome { get; set; }

    public string? Contatto { get; set; }

    public string? Indirizzo { get; set; }

}
