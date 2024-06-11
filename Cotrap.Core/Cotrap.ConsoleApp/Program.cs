
using Cotrap.Core.Allenamento;

var myClock = new CotrapClock();
var ospiti = new GestioneOspitiDatabase(myClock);
var gestione = new GestioneAtletaMemoria(ospiti);


gestione.CambiaPesoAdUnAtleta(1, 70);
gestione.AggiungiAttività(new Attività()
     {
     Categoria = CategoriaAttività.Pesi, Data = DateTime.Now, Descrizione = "Pesi", 
        DurataInMinuti = 60, Id = 1}, 1);



var atleti = gestione.EstraiAtleti();
atleti.ToList().ForEach(a => Console.WriteLine(a.ToString()));


var prova = new Prova(gestione);

