using Cotrap.Core;
using Cotrap.Core.AnalisiTesto;

//string fileDaAnalizzare = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\CostituzioneItaliana.txt";
string fileDaAnalizzare = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\5Maggio.txt";
//string fileDaAnalizzare = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\us_constitution.json";

Analisi analisi = new Analisi(fileDaAnalizzare);
var DizionarioParole = analisi.TrovaParolePiuFrequenti(10);
var parolaLunga = analisi.ParolaPiuLunga();
//foreach(var entry in DizionarioParole)
//{
//    Console.WriteLine($"{entry.Key} {entry.Value}");
    
//}

Console.WriteLine(parolaLunga);

