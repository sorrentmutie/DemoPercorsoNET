using Cotrap.Core.RandomUserMe.ViewModels;

namespace Cotrap.Core.RandomUserMe.ExtensionMethods;

public static class RandomUserExtensionMethods
{
    public static ViewModelPersona? ConvertToViewModel(this Result person)
    {

        if (person is null) return null;

        return new ViewModelPersona
        {
            Id = person.id?.value ?? string.Empty,
            NomeCompleto = $"{person.name?.first} {person.name?.last}",
            Indirizzo = $"{person.location?.street?.name} {person.location?.street?.number}, {person.location?.city}",
            DataDiNascita = person.dob?.date ?? DateTime.MinValue
        };
    }
}
