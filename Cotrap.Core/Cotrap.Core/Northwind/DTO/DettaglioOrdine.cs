namespace Cotrap.Core.Northwind.DTO;

public class DettaglioOrdine
{
    public required string NomeProdotto { get; set; }

    public decimal PrezzoUnitario { get; set; }

    public short Quantita { get; set; }

    public float Sconto { get; set; }

    //public virtual Products Product { get; set; }
}
