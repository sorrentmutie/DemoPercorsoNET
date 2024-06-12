using Cotrap.Core;
using Cotrap.Core.AnalisiTesto;

string fileCostituzione = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\CostituzioneItaliana.txt";
string fileMaggio = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\5Maggio.txt";
string fileUS = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\us_constitution.json";

//Analisi analisi = new Analisi(fileDaAnalizzare);
//var DizionarioParole = analisi.TrovaParolePiuFrequenti(10);
//var parolaLunga = analisi.ParolaPiuLunga();
//foreach(var entry in DizionarioParole)
//{
//    Console.WriteLine($"{entry.Key} {entry.Value}");
    
//}



Console.WriteLine($"Current Thread: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Main Program: {Thread.CurrentThread.IsBackground}");

var pathFiles = new string[] { fileCostituzione, fileMaggio, fileUS };

for (int i = 0; i < 3; i++)
{
   // ThreadPool.QueueUserWorkItem(new WaitCallback(EsaminaTesto), pathFiles[i]);
   var parolaPiuLunga = await EsaminaTestoAsync(pathFiles[i]);
   Console.WriteLine(parolaPiuLunga);
}


async Task<string> EsaminaTestoAsync(string path)
{
    Analisi analisi = new Analisi((string)path);
    return await analisi.ParolaPiuLungaASync();
}


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

