using Cotrap.Core.RandomUserMe.ViewModels;

namespace Cotrap.Core.RandomUserMe.Interfacce;

public interface IRandomUserData
{
    Task<RandomUserData?> GetRandomUserData();

    Task<ViewModelPersona?> GetViewModelPersona();

}
