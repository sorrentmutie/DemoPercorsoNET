using Cotrap.Core.Interfacce;
using System.Linq.Expressions;

namespace Cotrap.Northwind;

public  class CategoriesDataService
{
    private readonly IRepository<Category, int> repository;

    public CategoriesDataService(IRepository<Category, int> repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<CategoriaDTO>?> GetCategoriesAsync(
        Expression<Func<Category, bool>>? filter)
    {
        var categories = await repository.Filter(filter);

        return categories.Select(c => new CategoriaDTO
        {
            Id = c.Id,
            Nome   = c.CategoryName,
            Descrizione = c.Description
        });
    }

}
