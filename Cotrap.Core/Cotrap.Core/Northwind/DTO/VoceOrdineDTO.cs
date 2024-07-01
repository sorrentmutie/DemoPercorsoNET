namespace Cotrap.Core.Northwind.DTO;

public class VoceOrdineDTO
{
    public int OrderId { get; set; }
    public string? NomeProdotto { get; set; }
    public decimal PrezzoUnitario { get; set; } 
    public int Quantità { get; set; }
}
