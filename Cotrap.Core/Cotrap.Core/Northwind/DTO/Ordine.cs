namespace Cotrap.Core.Northwind.DTO;

public class Ordine
{
    public required int Id { get; set; }

    public DateTime? Data { get; set; }

    public decimal? Trasporto { get; set; }

    public required string Corriere { get; set; }

    public virtual IEnumerable<DettaglioOrdine> DettagliOrdini { get; set; } = new List<DettaglioOrdine>();

    public decimal Totale => DettagliOrdini.Sum(x => x.Quantita * x.PrezzoUnitario * (1.0M - (decimal)x.Sconto));
}
