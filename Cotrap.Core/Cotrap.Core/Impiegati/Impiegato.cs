namespace Cotrap.Core.Impiegati;

public enum Ruolo
{
    Amministrativo,
    Operativo,
    Manageriale
}


public class Impiegato
{
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public Ruolo Ruolo { get; set; }
    public double RAL { get; set; }
}
