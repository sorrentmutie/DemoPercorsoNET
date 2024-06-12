namespace Cotrap.Core.AnalisiTesto;

public class Analisi
{
    private string testo = "";
    private string path = "";
    
    public Analisi(string path)
    {
        this.path = path;
    }

    public string ParolaPiuLunga()
    {
        using StreamReader sr = new StreamReader(path);
        testo = sr.ReadToEnd();
        return testo.ParolaPiuLunga();
    }

    public Dictionary<string, int> TrovaParolePiuFrequenti(int n)
    {
        using StreamReader sr = new StreamReader(path);
        testo = sr.ReadToEnd();
        return testo.TrovaParolePiuFrequenti(n);
    }

    
    public async Task<string> ParolaPiuLungaASync()
    {
        using StreamReader sr = new StreamReader(path);
        var testo = await sr.ReadToEndAsync();
        return testo.ParolaPiuLunga();
    }

    public async Task<Dictionary<string, int>> TrovaParolePiuFrequentiAsync(int n)
    {
        using StreamReader sr = new StreamReader(path);
        testo = await sr.ReadToEndAsync();
        return testo.TrovaParolePiuFrequenti(n);
    }

}
