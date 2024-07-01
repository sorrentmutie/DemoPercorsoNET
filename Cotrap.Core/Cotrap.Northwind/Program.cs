

using Microsoft.EntityFrameworkCore;

NorthwindContext context = new NorthwindContext();
ICustomersNorthwindData data =
    new CustomersNorthwindSQlServerData(context);

IOrdersNorthwindData ordersNorthwindData =
    new OrdersNorthwindSQlServerData(context);

//ICategoriesNorthwindData categoriesNorthwindData =
//    new CategorieNorthwindSqlServerData(context);

IGenericNorthwindData<Category, int> categoriesGenericData =
    new GenericNorthwindData<Category, int>(context);


//var ordine = await ordersNorthwindData.EstraiOrdine(10264);

//if(ordine is not null)
//{
//    Console.WriteLine($"Ordine {ordine.Id} del {ordine.OrderDate} Cliente: {ordine.CustomerId}");

//    if(ordine.Voci is not null)
//    {
//        foreach (var voce in ordine.Voci)
//        {
//            Console.WriteLine($"Prodotto: {voce.NomeProdotto} Quantità: {voce.Quantità} Prezzo: {voce.PrezzoUnitario}");
//        }

//    }
//}

//var clienti = await data.GetClientiAsync();

//if (clienti is not null)
//{
//    foreach (var cliente in clienti)
//    {
//        Console.WriteLine($"{cliente.Id} {cliente.IndirizzoCompleto} Numero Ordini: {cliente.Ordini} Totale Fatture: {cliente.TotaleOrdini}");
//    }
//}

//context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

//var category = new Category {  CategoryName = "nc2",
//    Description = "Descrizione Nuova Categoria 2"
//};
//context.Categories.Add(category);

//var category29 = await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == 29);

//category.Description = "Descrizione Nuova Categoria 2 Modificata";
//if(category29 is not null)
//{
//    category29.CategoryName = "example 2";
//    category29.Description = "Descrizione example 2";
//}

//await context.SaveChangesAsync();

//var categoriaDTO = new CategoriaDTO { Id = 29, Nome = "Dopo Pranzo 2" , Descrizione = "desc"};
//await categoriesNorthwindData.ModificaCategoriaAsync(categoriaDTO);

//var categorie = await categoriesNorthwindData.GetCategorieAsync("Sea");
//if ((categorie is not null))
//{
//    foreach (var categoria in categorie)
//    {
//        Console.WriteLine(categoria.Nome);
//    }
//}


//var newCategory = new Category 
//{ CategoryName = "nc2", Description = "Descrizione Nuova Categoria 2" };

//await categoriesGenericData.AddItemAsync(newCategory);

//var categoryDb = await categoriesGenericData.GetItemAsync(29);
//if (categoryDb is not null)
//{
//    categoryDb.Description = "XXXXXXX";
//    await categoriesGenericData.UpdateItemAsync(categoryDb);
//}

//var categories = await categoriesGenericData.GetItemsAsync();
//if (categories is not null)
//{
//    var x = categories.Where(x => x.CategoryName.Contains("Sea"));
//}

var categories =  categoriesGenericData.GetItems();
if(categories is not null)
{
    var x = await categories
        .Where(x => x.CategoryName.Contains("Sea"))
        .ToListAsync();
}

Console.WriteLine("Fine programma");
