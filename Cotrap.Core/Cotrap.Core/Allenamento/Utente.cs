using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Pesi;

public class Utente : IEntity
{
    public int Id { get ; set ; }
    public string? Email { get; set; }
    public DateTime DataUltimoAccesso { get; set; }
}
