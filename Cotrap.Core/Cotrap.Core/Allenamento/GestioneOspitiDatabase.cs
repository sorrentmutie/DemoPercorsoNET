using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Allenamento;

public class GestioneOspitiDatabase : IGestioneOspiti
{
    private readonly IClock clock;

    public GestioneOspitiDatabase(IClock clock)
    {
        this.clock = clock;
    }

    public IEnumerable<Atleta> AtletiOspiti()
    {
        if (clock.Now().Hour < 12)
        {
            return new List<Atleta>()
            {
                new Atleta() { Id = 5, Nome = "John", Cognome = "Smith", DataNascita = new DateTime(1984, 1, 1), Peso = 100, Altezza = 200 },
            };

        }
        else
        {
            return new List<Atleta>()
            {
                new Atleta() { Id = 6, Nome = "Kim", Cognome = "Jong", DataNascita = new DateTime(1984, 1, 1), Peso = 100, Altezza = 200 },
                new Atleta() { Id = 7, Nome = "Kim", Cognome = "Wang", DataNascita = new DateTime(1984, 1, 1), Peso = 100, Altezza = 200 },

            };
        }
    }
}
