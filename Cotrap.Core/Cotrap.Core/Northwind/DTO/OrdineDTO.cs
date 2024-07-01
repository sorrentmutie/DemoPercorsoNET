using Cotrap.Core.Interfacce;
namespace Cotrap.Core.Northwind.DTO;

public class OrdineDTO: IEntity
{

    public int Id { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? OrderDate { get; set; }

    public List<VoceOrdineDTO>? Voci { get; set; }
}
