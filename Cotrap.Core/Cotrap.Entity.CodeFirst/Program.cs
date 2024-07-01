// See https://aka.ms/new-console-template for more information
using Cotrap.Core.Interfacce;
using Cotrap.Core.Northwind.DTO;
using Cotrap.Data.Models;
using Cotrap.Data.Northwind.Models;
using Cotrap.Entity.CodeFirst;
using Cotrap.Northwind;

Console.WriteLine("Hello, World!");

var bloggingContext = new BloggingContext();

IRepository<Blog, int> repository = 
    new EFRepository<Blog, int>(bloggingContext);

IDataService<Blog, BlogDTO, BlogCreaDTO, int> servizioCustomer = new ServizioBlog(repository);



var salvatore = new Author { Name = "Sal", Surname = "Sor" };
bloggingContext.Authors!.Add(salvatore);
await bloggingContext.SaveChangesAsync();

var blog = new Blog { Url = "http://gazzetta.it" };
blog.Posts = new List<Post>
{
    new Post { Title = "Titolo 40", Content = "Contenuto", Date = DateTime.Now, 
        Author = new Author { Name = "Mario", Surname = "Rossi" } },
    //new Post { Title = "Titolo 5", Content = "Contenuto", Date = DateTime.Now },
    //new Post { Title = "Titolo 6", Content = "Contenuto", Date = DateTime.Now },
};

if(bloggingContext is not null)
{
    bloggingContext.Blogs!.Add(blog);
    await bloggingContext.SaveChangesAsync();
    Console.WriteLine("Terminata esecuzione");
}

public class BlogCreaDTO
{
}