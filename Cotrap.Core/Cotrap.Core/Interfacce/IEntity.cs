namespace Cotrap.Core.Interfacce;

public interface IEntity
{
    public int Id { get; set; }
}

public interface IEntity<T>
{
    public T Id { get; set; }
}
