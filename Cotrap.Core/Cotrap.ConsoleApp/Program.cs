
using Cotrap.Core.Allenamento;
using Cotrap.Core.RandomUserMe.Interfacce;
using Cotrap.Core.RandomUserMe;
using Cotrap.Core.AnalisiTesto;
using System.Net;
using System.Xml;
using Cotrap.Core.Reqres.Interfacce;
using Cotrap.Core.Reqres;
using System;

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

#region "Codice commentato"
//var t1 = new Task(FaiQualcosa);
//var t2 = t1.ContinueWith( (t)  => { Console.WriteLine("Secondo Task"); } );
//t1.Start();
//Task.WaitAll(t1, t2);

//Console.WriteLine("Fine del programma");

//var x = Download().GetAwaiter().GetResult();
//var analisi = new Analisi("");
//var urls = new List<string>() { "https://www.nuget.org/packages/TaskParallelLibrary/", "https://www.ansa.it/", "https://sitasudtrasporti.it/"};

//foreach (var url in urls)
//{
//    var contenuto = await Download(url);
//    var pl = analisi.ParolaPiuLungaDaTesto(contenuto);

//    Console.WriteLine($"Parola..... {pl}");
//}
//var testo = await Download();
//Console.WriteLine(testo);

//async Task<string> Download()
//{
//    var downloader = new WebClient();
//    var t = await downloader.DownloadStringTaskAsync("http://www.google.com");
//    return t;
//}
#endregion





//IRandomUserData randomUserData = new ServizioDatiHttp();
//var vmPersona = await randomUserData.GetViewModelPersona();
//if (vmPersona == null) return;
//Console.WriteLine($"{vmPersona.NomeCompleto} {vmPersona.DataDiNascita} {vmPersona.Indirizzo}");

//if(data is not null && data.Results is not null && data.Results.Length > 0)
//{
//    var person = data.Results[0];
//    Console.WriteLine($"Email: {person.email} {person.name.first} {person.name.last}");
//}

//async Task<string> Download(string url)
//{
//    var downloader = new WebClient();
//    var t = await downloader.DownloadStringTaskAsync(url);
//    return t;
//}




HttpClient httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://reqres.in/api/users?page=2");
IReqres reqres = new ReqresHttpService(httpClient);

var vm = await reqres.GetPeopleViewModel();
if (vm is null) return;
foreach (var person in vm)
{
    Console.WriteLine($"{person.NomeCompleto} {person.Indirizzo}");
}


await reqres.RegisterPerson(
    new RegisterVM { email = "qwert@gmail.com", password = "Password1234!" });




//if (dataReqres is not null)
//{
//    var people = dataReqres.data;
//    foreach (var person in people)
//    {
//        Console.WriteLine($"{person.first_name} {person.last_name}");
//    }
//}

//var people = await reqres.GetPeopleAsync();
//if(people is null) return;
//foreach (var person in people)
//{
//    Console.WriteLine($"{person.first_name} {person.last_name}");
//}

