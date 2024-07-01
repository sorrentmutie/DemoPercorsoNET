using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Northwind.DTO;

public class CategoriaDTO : IEntity
{
    public int Id { get; set; }
    public required string Nome { get; set; } 
    public string? Descrizione { get; set; }
}

//public class CategoriaCreaDTO
//{
//    public required string Nome { get; set; } 
//    public string? Descrizione { get; set; }
//}