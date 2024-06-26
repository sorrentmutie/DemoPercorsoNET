using Cotrap.ConsoleApp;
using Cotrap.Core.Impiegati.Interfacce;

Console.WriteLine("Ciao");

//var impiegati = new List<Impiegato>()
//{ new Impiegato {  Cognome = "Rossi", DataNascita = DateTime.Today.AddYears(-30) , Nome = "Mario",
//       Ruolo = Ruolo.Amministrativo, RAL = 40000} ,
//  new Impiegato {  Cognome = "Verdi", DataNascita = DateTime.Today.AddYears(-40) , Nome = "Luca",
//        Ruolo = Ruolo.Operativo, RAL = 35000},
//  new Impiegato {  Cognome = "Bianchi", DataNascita = DateTime.Today.AddYears(-50) , Nome = "Paolo",
//       Ruolo = Ruolo.Manageriale, RAL = 50000}
//};

// Func<Impiegato, bool> predicate = (i) => i.Ruolo == Ruolo.Operativo;

//var operativi = impiegati
//        .Where(i => i.Ruolo == Ruolo.Operativo)
//        .OrderBy(i => i.DataNascita)
//        .Select(i => new { NomeCompleto = i.Nome + " " + i.Cognome,  Nascita = i.DataNascita });

IGestioneImpiegati gestioneImpiegati = new GestioneOperativi();
var operativi = gestioneImpiegati.GetImpiegatiOperativi();

foreach (var item in operativi)
{
    Console.WriteLine($"{item.Nome} {item.Cognome} - {item.DataNascita}");
}


