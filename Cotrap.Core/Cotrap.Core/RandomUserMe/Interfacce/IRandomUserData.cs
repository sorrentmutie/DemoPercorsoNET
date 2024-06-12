namespace Cotrap.Core.RandomUserMe.Interfacce;

public interface IRandomUserData
{
    Task<RandomUserData?> GetRandomUserData();
}
