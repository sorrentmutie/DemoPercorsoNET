using System.ComponentModel.DataAnnotations;

namespace Cotrap.Core.Northwind.DTO;

public class CustomerCreaDTO
{
    [Length(5,5, ErrorMessage = "La lunghezza massima è di 5 caratteri")]
    public string? Chiave {get; set; }
 
    public string? Nome { get; set; }

    public string? Contatto { get; set; }

    public string? Indirizzo { get; set; }
}
