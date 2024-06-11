using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Allenamento;

public class Attività : IEntity
{
   public int Id { get; set; }
   public DateTime Data { get; set; }
   public CategoriaAttività Categoria { get; set; } = CategoriaAttività.NonDefinito;
   public string Descrizione { get; set; } = string.Empty;
   // public Atleta? Atleta { get; set; }
   public int DurataInMinuti { get; set; }
}
