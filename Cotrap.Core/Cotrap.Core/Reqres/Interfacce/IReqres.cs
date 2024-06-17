

using Cotrap.Core.RandomUserMe.ViewModels;

namespace Cotrap.Core.Reqres.Interfacce;

public interface IReqres
{
    //Task<Reqres?> GetReqresData();

    Task<Person[]?> GetPeopleAsync();

    Task<IEnumerable<ViewModelPersona>?> GetPeopleViewModel();

    Task RegisterPerson(RegisterVM registerVM);

}
