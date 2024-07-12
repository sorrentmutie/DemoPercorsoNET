
public class DettaglioCliente
{
    public string id { get; set; } = string.Empty;
    public string nome { get; set; } = string.Empty;
    public string contatto { get; set; } = string.Empty;
    public string indirizzoCompleto { get; set; } = string.Empty;
    public string telefono { get; set; } = string.Empty;
    public List<Ordine> ordini { get; set; } = new List<Ordine>();
    public int numeroTotaleOrdini { get; set; }
    public float sommaTotaleOrdini { get; set; }
    public UltimoOrdine? ultimoOrdine { get; set; }
    public DateTime dataUltimoOrdine { get; set; }
    public int numeroTotaliProdotti { get; set; }
    public List<Prodotto> listaProdotti { get; set; } = new List<Prodotto>();
}

public class UltimoOrdine
{
    public int id { get; set; }
    public DateTime data { get; set; }
    public float trasporto { get; set; }
    public string corriere { get; set; } = string.Empty;
    public List<DettaglioOrdine> dettaglioOrdini { get; set; } = new List<DettaglioOrdine>();
    public float totale { get; set; }
}

public class DettaglioOrdine
{
    public string nomeProdotto { get; set; } = string.Empty;
    public float prezzoUnitario { get; set; }
    public int quantita { get; set; }
    public float sconto { get; set; }
}

public class Ordine
{
    public int id { get; set; }
    public DateTime data { get; set; }
    public float trasporto { get; set; }
    public string corriere { get; set; } = string.Empty;

    public List<DettaglioOrdine> dettaglioOrdini { get; set; } = new List<DettaglioOrdine>();
    public float totale { get; set; }
}



public class Prodotto
{
    public int id { get; set; }
    public string nome { get; set; } = string.Empty;
    public string fornitore { get; set; } = string.Empty;
}
