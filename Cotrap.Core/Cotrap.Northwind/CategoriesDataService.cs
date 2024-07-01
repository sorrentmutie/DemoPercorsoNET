using Cotrap.Core.Interfacce;
using System.Linq.Expressions;

namespace Cotrap.Northwind;

//public class CategoriesDataService : ICategoriesDataService
//{
//    private readonly IRepository<Category, int> repository;

//    public CategoriesDataService(IRepository<Category, int> repository)
//    {
//        this.repository = repository;
//    }

//    public async Task AddNewCategory(CategoriaCreaDTO category)
//    {
//        var categoria = new Category { CategoryName = category.Nome, Description = category.Descrizione };
//        await repository.CreateAsync(categoria);
//    }

//    public async Task<int> AddNewCategoryWithId(CategoriaCreaDTO category)
//    {
//        var categoria = new Category { CategoryName = category.Nome, Description = category.Descrizione };
//        return await repository.CreateAsyncWithId(categoria);
//    }

//    public async Task DeleteCategory(int Id)
//    {
//         await repository.DeleteAsync(Id);
//    }

//    public async Task<IEnumerable<CategoriaDTO>?> GetCategoriesAsync(
//        Expression<Func<Category, bool>>? filter)
//    {
//        var categories = await repository.Filter(filter);

//        return categories.Select(c => new CategoriaDTO
//        {
//            Id = c.Id,
//            Nome = c.CategoryName,
//            Descrizione = c.Description
//        });
//    }

//    public async Task<CategoriaDTO?> GetCategoriesAsyncById(int Id)
//    {
//        var x = await repository.GetByIdAsync(Id);
//        if (x is not null)
//        {
//            return new CategoriaDTO() { Id = x.Id, Descrizione = x.Description, Nome = x.CategoryName };
//        }
//        else return null;
//    }

//    public async Task UpdateCategory(CategoriaDTO category)
//    {
//        var categoryDb = new Category() { CategoryName = category.Nome, Description = category.Descrizione, Id = category.Id };
//        await repository.UpdateAsync(categoryDb);
//    }
//}
