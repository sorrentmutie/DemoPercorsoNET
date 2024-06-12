﻿
using Cotrap.Core.Allenamento;
using System.Net;
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


#region Codice commentato

////var prova = new Prova(gestione);
//var r = new Random();
//int total = 0;


//for (int i = 0; i < 10; i++)
//{
//    var t = new Thread(new ThreadStart(FaiQualcosa));
//    t.Start();
//}

//Console.WriteLine($"Current Thread: {Thread.CurrentThread.ManagedThreadId}");
//Console.WriteLine($"Main Program: {Thread.CurrentThread.IsBackground}");

//var stato = 100;
//for (int i = 0; i < 10; i++)
//{
//    ThreadPool.QueueUserWorkItem(new WaitCallback(FaiQualcosa),stato);
//}


//Console.WriteLine("Fine dell'esecuzione");
//Console.ReadLine();


//void FaiQualcosa(object? state)
//{
//   var id = Thread.CurrentThread.ManagedThreadId;
//    Console.WriteLine($"Stato = {state}");
//    // var x = total;
//    var sleepTime = r.Next(1000, 15000);
//   Console.WriteLine($"Ciao sto per fare qualcosa {id} {Thread.CurrentThread.IsBackground}");
//   Thread.Sleep(sleepTime);
//    if(state is not null)
//    {
//        var z = (int)state + 1;
//        state = z;
//        Console.WriteLine($"Ho finito di fare qualcosa  {id} - {z}");
//    }
//}

#endregion

//var t1 = new Task(FaiQualcosa);
//var t2 = t1.ContinueWith( (t)  => { Console.WriteLine("Secondo Task"); } );
//t1.Start();
//Task.WaitAll(t1, t2);

Console.WriteLine("Fine del programma");

//var x = Download().GetAwaiter().GetResult();
var testo = await Download();
Console.WriteLine(testo);



void FaiQualcosa()
{
    Console.WriteLine("Esecuzione del task");
    Thread.Sleep(5000);
    Console.WriteLine("Fine del task");
}

async Task<string> Download()
{
    var downloader = new WebClient();
    var t = await downloader.DownloadStringTaskAsync("http://www.google.com");
    return t;
}