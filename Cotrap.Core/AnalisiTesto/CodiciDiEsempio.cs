using Cotrap.Core.Reqres.Interfacce;
using Cotrap.Core.Reqres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AnalisiTesto
{

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




    //    HttpClient httpClient = new HttpClient();
    //    httpClient.BaseAddress = new Uri("https://reqres.in/api/users?page=2");
    //    IReqres reqres = new ReqresHttpService(httpClient);

    //    var vm = await reqres.GetPeopleViewModel();
    //if (vm is null) return;
    //foreach (var person in vm)
    //{
    //    Console.WriteLine($"{person.NomeCompleto} {person.Indirizzo}");
    //}


    //await reqres.RegisterPerson(
    //    new RegisterVM { email = "qwert@gmail.com", password = "Password1234!" });




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

    //string fileCostituzione = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\CostituzioneItaliana.txt";
    //string fileMaggio = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\5Maggio.txt";
    //string fileUS = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\us_constitution.json";

    //Analisi analisi = new Analisi(fileDaAnalizzare);
    //var DizionarioParole = analisi.TrovaParolePiuFrequenti(10);
    //var parolaLunga = analisi.ParolaPiuLunga();
    //foreach(var entry in DizionarioParole)
    //{
    //    Console.WriteLine($"{entry.Key} {entry.Value}");

    //}



    //Console.WriteLine($"Current Thread: {Thread.CurrentThread.ManagedThreadId}");
    //Console.WriteLine($"Main Program: {Thread.CurrentThread.IsBackground}");

    //var pathFiles = new string[] { fileCostituzione, fileMaggio, fileUS };

    //for (int i = 0; i < 3; i++)
    //{
    //   // ThreadPool.QueueUserWorkItem(new WaitCallback(EsaminaTesto), pathFiles[i]);
    //   var parolaPiuLunga = await EsaminaTestoAsync(pathFiles[i]);
    //   Console.WriteLine(parolaPiuLunga);
    //}


    //async Task<string> EsaminaTestoAsync(string path)
    //{
    //    Analisi analisi = new Analisi((string)path);
    //    return await analisi.ParolaPiuLungaAsync();
    //}


    //for (int i = 0; i < 10; i++)
    //{
    //    var numeroRandom = await RandomIntAsync();
    //    Console.WriteLine(numeroRandom);
    //}

    //Parallel.For(1, 100, (i) => { Console.WriteLine(i); });
    //Parallel.For(1, 100, (i) => {
    //    Random r = new Random();
    //    var x = r.Next(0, 9);
    //    Thread.Sleep(r.Next(1000, 10000));
    //    Console.WriteLine($"{i} {x}");
    //});

    //Task<int> RandomIntAsync()
    //{
    //    Random r = new Random();
    //    var x = r.Next(0, 9);
    //    Thread.Sleep(2000);
    //    return Task.FromResult(x);
    //}


    //Console.WriteLine("Fine dell'esecuzione");
    //Console.ReadLine();


    //void EsaminaTesto(object? path)
    //{
    //    var id = Thread.CurrentThread.ManagedThreadId;
    //    Console.WriteLine($"Path = {path}");   
    //    Console.WriteLine($"Ciao sto leggendo {id} {Thread.CurrentThread.IsBackground}");
    //    if (path is not null)
    //    {
    //        Analisi analisi = new Analisi((string)path);
    //        var parolaLunga = analisi.ParolaPiuLunga();
    //        Console.WriteLine($"Parola più lunga: {parolaLunga} del thread: {id}");
    //        Console.WriteLine($"Ho finito di fare qualcosa  {id}");
    //    }
    //}


    //void StampaQualcosa(string messaggio)
    //{
    //    Console.WriteLine(messaggio);
    //}

    //void StampaQualcosa2(string messaggio)
    //{
    //    Console.WriteLine(messaggio);
    //}


    //int Somma(int a, int b)
    //{
    //    return a + b;
    //}


    //void DoSomething()
    //{
    //    //var random = new Random();
    //    //var x = random.Next(1, 10);
    //    //StampaDelegate stampa = StampaQualcosa;

    //    //if (x >= 5)
    //    //{
    //    //    stampa = StampaQualcosa2;

    //    //}

    //    //stampa("Ciao Ciao");
    //    //EsempioConArgomentoDelegato(5, 6, stampa);

    //    var obj = new MyClass();
    //    StampaDelegate stampa = obj.Message2;

    //}


    //void EsempioConArgomentoDelegato(int a, int b, StampaDelegate mioDelegato)
    //{
    //    var somma = a + b;
    //    mioDelegato($"La somma di {a} e {b} è {somma}");
    //}

    //delegate void StampaDelegate(string messaggio);
    //delegate int SommaDelegate(int a, int b);

    //public class MyClass
    //{
    //    public void Message1(string message)
    //    {
    //        Console.WriteLine(message);
    //    }
    //    public void Message2(string message)
    //    {
    //        Console.WriteLine("2 " + message);
    //    }
    //}





    internal class CodiciDiEsempio
    {
    }
}
