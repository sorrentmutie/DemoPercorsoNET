namespace Cotrap.Core.AnalisiTesto;

public class Analisi
{
    private string testo = "";

    public Analisi(string path)
    {
        using StreamReader sr = new StreamReader(path);
        testo = sr.ReadToEnd();
    }

    public string ParolaPiuLunga()
    {
        return testo.ParolaPiuLunga();
    }

    public Dictionary<string, int> TrovaParolePiuFrequenti(int n)
    {
        return testo.TrovaParolePiuFrequenti(n);
    }

    
    
}
