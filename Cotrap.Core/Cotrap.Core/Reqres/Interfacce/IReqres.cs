

namespace Cotrap.Core.Reqres.Interfacce;

public interface IReqres
{
    //Task<Reqres?> GetReqresData();

    Task<Person[]?> GetPeopleAsync();
}
