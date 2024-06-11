using Cotrap.Core.Interfacce;
using System.Text;

namespace Cotrap.Core.Allenamento;

public class Atleta : IEntity
{
    public int Id { get; set ; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; } 
    public DateTime DataNascita { get; set; }
    public int Altezza { get; set; }
    public int Peso { get; set; }
    public int IdUtente { get; set; }

    public List<Attività> Attività { get; set; } = new List<Attività>();

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Atleta: {Id} {Nome} {Cognome} {Peso}");
        foreach (var attività in Attività)
        {
            sb.AppendLine($"Attività: {attività.Id} {attività.Categoria} {attività.Data} {attività.DurataInMinuti}");
        }
        return sb.ToString();   
    }


    //public Atleta(string nome, string cognome)
    //{
    //    Nome = nome;
    //    Cognome = cognome;
    //}

    //public void CambiaPeso(int peso)
    //{
    //    Peso = peso;
    //}

}

// public record AtletaRecord(string Nome, string Cognome, DateTime DataNascita, int Altezza, int Peso);
// var mario = new AtletaRecord("Mario", "Rossi", new DateTime(1980, 1, 1), 180, 80);
// var maria = mario with { Nome = "Maria" };