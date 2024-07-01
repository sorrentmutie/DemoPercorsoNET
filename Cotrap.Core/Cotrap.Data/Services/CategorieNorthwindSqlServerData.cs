using Cotrap.Core.Northwind.DTO;
using Cotrap.Core.Northwind.Interfaces;
using Cotrap.Data.Northwind.Models;
using Microsoft.EntityFrameworkCore;

namespace Cotrap.Data.Services;

public class CategorieNorthwindSqlServerData : ICategoriesNorthwindData
{
    private readonly NorthwindContext northwindContext;

    public CategorieNorthwindSqlServerData(NorthwindContext northwindContext)
    {
        this.northwindContext = northwindContext;
    }

    public async Task AggiungiCategoriaAsync(string Nome, string Descrizione)
    {
        var category = new Category
        {
            CategoryName = Nome,
            Description = Descrizione
        };
        northwindContext.Categories.Add(category);
        await northwindContext.SaveChangesAsync();
    }

    public async Task<CategoriaDTO?> GetCategoriaAsync(int id)
    {
        var categoria = await northwindContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
        if(categoria == null) return null;
        return new CategoriaDTO
        {
            Id = categoria.Id,
            Nome = categoria.CategoryName,
            Descrizione = categoria.Description
        };
    }

    public async Task<IEnumerable<CategoriaDTO>?> GetCategorieAsync(string search = "")
    {
        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        var data = northwindContext.Categories;
        var categories = new List<CategoriaDTO>();

        if (search == string.Empty)
        {
            categories =  await data.Select(c => new CategoriaDTO
            {
                Id = c.Id,
                Nome = c.CategoryName,
                Descrizione = c.Description
            }).ToListAsync();
        }
        else
        {
            categories =  await data.Where(c => c.CategoryName.Contains(search) || c.Description.Contains(search))
                .Select(c => new CategoriaDTO
                {
                    Id = c.Id,
                    Nome = c.CategoryName,
                    Descrizione = c.Description
                }).ToListAsync();
        }

        northwindContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return categories;
    }

    public async Task ModificaCategoriaAsync(CategoriaDTO categoriaModificata)
    {
        var categoriaDb = await northwindContext.Categories
            .FirstOrDefaultAsync(x => x.Id == categoriaModificata.Id);
        if(categoriaDb is not null)
        {
            //categoriaDb.CategoryName = categoriaModificata.Nome;
            //categoriaDb.Description = categoriaModificata.Descrizione;

            northwindContext.Entry(categoriaDb).State = EntityState.Detached;
            var category = new Category
            {
                Id = categoriaModificata.Id,
                CategoryName = categoriaModificata.Nome,
                Description = categoriaModificata.Descrizione
            };
            northwindContext.Entry(category).State = EntityState.Modified;

            await northwindContext.SaveChangesAsync();
        }
        

    }
}
