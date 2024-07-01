using Cotrap.Core.Northwind.DTO;

namespace Cotrap.Core.Northwind.Interfaces;

public interface ICategoriesNorthwindData
{
   // Task<IEnumerable<CategoriaDTO>?> RicercaCategorieAsync(string search);
    Task<IEnumerable<CategoriaDTO>?> GetCategorieAsync(string search = "");
    Task<CategoriaDTO?> GetCategoriaAsync(int id);
    Task AggiungiCategoriaAsync(string Nome, string Descrizione);
    Task ModificaCategoriaAsync(CategoriaDTO categoriaModificata);
}
