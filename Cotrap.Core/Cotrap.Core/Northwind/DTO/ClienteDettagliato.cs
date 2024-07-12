namespace Cotrap.Core.Northwind.DTO;

public class ClienteDettagliato
{
    public required string Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public string Contatto { get; set; } = string.Empty;

    public string IndirizzoCompleto { get; set; } = string.Empty;

    public string Telefono { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Id} {Nome} {IndirizzoCompleto} {Telefono} {Contatto}";
    }

    public IEnumerable<Ordine> Ordini { get; set; } = new List<Ordine>();

    public int NumeroTotaleOrdini => Ordini.Count();

    public decimal SommaTotaleOrdini => Ordini.Sum(x => x.Totale);

    public Ordine? UltimoOrdine => Ordini.OrderByDescending(x => x.Data).FirstOrDefault();

    public DateTime? DataUltimoOrdine => Ordini.OrderByDescending(x => x.Data)?.FirstOrDefault()?.Data;

    public int NumeroTotaliProdotti => Ordini.Sum(o => o.DettagliOrdini.Sum(od => od.Quantita));

    public IEnumerable<ProdottoDTO>? ListaProdotti { get; set; }
}
