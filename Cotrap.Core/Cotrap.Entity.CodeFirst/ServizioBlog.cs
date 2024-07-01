// See https://aka.ms/new-console-template for more information
using Cotrap.Core.Interfacce;
using Cotrap.Entity.CodeFirst;
using Cotrap.Northwind;
using System.Linq.Expressions;

public class ServizioBlog : IDataService<Blog, BlogDTO, BlogCreaDTO, int>
{
    private readonly IRepository<Blog, int> repository;

    public ServizioBlog(IRepository<Blog, int> repository)
    {
        this.repository = repository;
    }

    public Task AddNew(BlogCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddNewWithId(BlogCreaDTO category)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<BlogDTO>?> GetAsync(Expression<Func<Blog, bool>>? filter)
    {
        throw new NotImplementedException();
    }

    public Task<BlogDTO?> GetAsyncById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task Update(BlogDTO category)
    {
        throw new NotImplementedException();
    }
}
