namespace Cotrap.Core.Northwind.DTO;

public class ClienteDTO
{
    public string Id { get; set; } = string.Empty;
    public string? Contatto { get; set; }
    public string? IndirizzoCompleto { get; set; }
    public string? Telefono { get; set; }
    public int Ordini { get; set; }
    public decimal TotaleOrdini { get; set; }
}
