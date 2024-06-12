using Cotrap.Core.AnalisiTesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotrap.Test;

[TestClass]
public class UnitTestAnalisiTesto
{
    [TestMethod]
    [Ignore]
    public void CheckStringaNullaSePathSbagliato()
    {
        string fileDaAnalizzare = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\CostituzioneItalian.txt";

        Assert.ThrowsException<FileNotFoundException>(() => new Analisi(fileDaAnalizzare));
    }

    //[TestMethod]
    //public void CheckStringaRestituiraLunghezzaMaggioreDiZero()
    //{
    //    string fileDaAnalizzare = @"C:\SVILUPPI\CORSO\TestoDaAnlizzare\CostituzioneItaliana.txt";

    //    Analisi analisi = new Analisi(fileDaAnalizzare);
    //    var testo = analisi.LeggiDocumento();
    //    Assert.AreEqual(true, testo.Length > 0);
    //}
}
