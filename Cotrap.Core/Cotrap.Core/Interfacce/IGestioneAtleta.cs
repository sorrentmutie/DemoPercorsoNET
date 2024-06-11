using Cotrap.Core.Allenamento;

namespace Cotrap.Core.Interfacce;

public interface IGestioneAtleta
{
    void CambiaPesoAdUnAtleta(int atletaId, int nuovoPeso);
    IEnumerable<Atleta> EstraiAtleti(string query = "");
 //   List<Atleta> Ricerca(string query);
    Atleta? EstraiAtleta(int atletaId);
    void AggiungiAtleta(Atleta atleta);
    void ModificaAtleta(Atleta atleta);
    void EliminaAtleta(int atletaId);
}

// IGestioneAtleta x = new GestioneAtletaMemoria();