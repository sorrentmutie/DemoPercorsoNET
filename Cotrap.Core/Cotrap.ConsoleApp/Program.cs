
using Cotrap.Core.Allenamento;
using System.Xml;

//var myClock = new CotrapClock();
//var ospiti = new GestioneOspitiDatabase(myClock);
//var gestione = new GestioneAtletaMemoria(ospiti);


//gestione.CambiaPesoAdUnAtleta(1, 70);
//gestione.AggiungiAttività(new Attività()
//     {
//     Categoria = CategoriaAttività.Pesi, Data = DateTime.Now, Descrizione = "Pesi", 
//        DurataInMinuti = 60, Id = 1}, 1);



//var atleti = gestione.EstraiAtleti();
//atleti.ToList().ForEach(a => Console.WriteLine(a.ToString()));


//var prova = new Prova(gestione);
var r = new Random();
int total = 0;


//for (int i = 0; i < 10; i++)
//{
//    var t = new Thread(new ThreadStart(FaiQualcosa));
//    t.Start();
//}

Console.WriteLine($"Current Thread: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Main Program: {Thread.CurrentThread.IsBackground}");

var stato = 100;
for (int i = 0; i < 10; i++)
{
    ThreadPool.QueueUserWorkItem(new WaitCallback(FaiQualcosa),stato);
}


Console.WriteLine("Fine dell'esecuzione");
Console.ReadLine();


void FaiQualcosa(object? state)
{
   var id = Thread.CurrentThread.ManagedThreadId;
    Console.WriteLine($"Stato = {state}");
    // var x = total;
    var sleepTime = r.Next(1000, 15000);
   Console.WriteLine($"Ciao sto per fare qualcosa {id} {Thread.CurrentThread.IsBackground}");
   Thread.Sleep(sleepTime);
    if(state is not null)
    {
        var z = (int)state + 1;
        state = z;
        Console.WriteLine($"Ho finito di fare qualcosa  {id} - {z}");
    }
}


