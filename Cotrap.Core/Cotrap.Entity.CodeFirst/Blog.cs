using Cotrap.Core.Interfacce;
using Microsoft.EntityFrameworkCore;

namespace Cotrap.Entity.CodeFirst;

public class Blog: IEntity<int>
{
    public int Id { get; set; }
    public string? Url { get; set; }

    public List<Post>? Posts { get; set; }

}

public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime Date { get; set; }

    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}

public class Author
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public List<Post>? Posts { get; set; }
}



public class BloggingContext: DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=blogging.db");
    }

}