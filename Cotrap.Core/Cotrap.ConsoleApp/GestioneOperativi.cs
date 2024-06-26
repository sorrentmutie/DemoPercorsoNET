using Cotrap.Core.Impiegati.Interfacce;

namespace Cotrap.ConsoleApp;

public class GestioneOperativi : IGestioneImpiegati
{
    private static List<Impiegato> _impiegati = new List<Impiegato>()
    {
      new Impiegato {  Cognome = "Rossi", DataNascita = DateTime.Today.AddYears(-30) , Nome = "Mario",
           Ruolo = Ruolo.Amministrativo, RAL = 40000} ,
      new Impiegato {  Cognome = "Verdi", DataNascita = DateTime.Today.AddYears(-40) , Nome = "Luca",
            Ruolo = Ruolo.Operativo, RAL = 35000},
      new Impiegato {  Cognome = "Bianchi", DataNascita = DateTime.Today.AddYears(-50) , Nome = "Paolo",
           Ruolo = Ruolo.Manageriale, RAL = 50000}
    };


    public IEnumerable<Impiegato> GetImpiegatiOperativi()
    {
        return _impiegati.Where(i => i.Ruolo == Ruolo.Operativo);
    }
}
