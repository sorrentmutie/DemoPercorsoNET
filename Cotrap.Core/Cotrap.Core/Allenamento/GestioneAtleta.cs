using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Allenamento;

public class GestioneAtletaMemoria : IGestioneAtleta, IGestioneAttività
{
    private static List<Atleta> _atleti = new List<Atleta>()
    { 
      new Atleta() { Id = 1, Nome = "Mario", Cognome = "Rossi", DataNascita = new DateTime(1980, 1, 1), Peso = 80, Altezza = 180 },
      new Atleta() { Id = 2, Nome = "Luigi", Cognome = "Bianchi", DataNascita = new DateTime(1981, 1, 1), Peso = 85, Altezza = 185 },
      new Atleta() { Id = 3, Nome = "Giuseppe", Cognome = "Verdi", DataNascita = new DateTime(1982, 1, 1), Peso = 90, Altezza = 190 },
      new Atleta() { Id = 4, Nome = "Filippo", Cognome = "Gialli", DataNascita = new DateTime(1983, 1, 1), Peso = 95, Altezza = 195 },
    };
    private readonly IGestioneOspiti _ospiti;

    public GestioneAtletaMemoria(IGestioneOspiti ospiti)
    {
        this._ospiti = ospiti;
    }


    public void AggiungiAtleta(Atleta atleta)
    {
        _atleti.Add(atleta);
    }

    public void AggiungiAttività(Attività attività, int idAtleta)
    {
        var atleta = EstraiAtleta(idAtleta);
        if(atleta is not null)
        {
            atleta.Attività.Add(attività);
        }
    }

    public void CambiaPesoAdUnAtleta(int atletaId, int nuovoPeso)
    {
        if(nuovoPeso < 200)
        {
            var atleta = EstraiAtleta(atletaId);
            if (atleta is not null)
            {
                atleta.Peso = nuovoPeso;
            }
        } else
        {
            throw new Exception("Allarme Peso");
        }
    }

    public void EliminaAtleta(int atletaId)
    {
        var atleta = EstraiAtleta(atletaId);
        if(atleta is not null)
        {
            _atleti.Remove(atleta);
        }   
    }

    public Atleta? EstraiAtleta(int atletaId)
    {
     
        var atleta = _atleti.FirstOrDefault(a => a.Id == atletaId);
        return atleta;
    }

    public IEnumerable<Atleta> EstraiAtleti(string query = "")
    {
        var ospiti = _ospiti.AtletiOspiti().ToList();
        if (string.IsNullOrEmpty(query))
        {
            
            ospiti.AddRange(_atleti);
            
        } else
        {   
            
            var selezionati = _atleti.Where(
                a => a.Nome!.ToUpper().Contains(query.ToUpper()) ||
                a.Cognome!.ToUpper().Contains(query.ToUpper()));
            ospiti.AddRange(selezionati);
        }
        return ospiti;
    }

    public List<Attività> EstraiAttività(int atletaId)
    {
        var atleta = EstraiAtleta(atletaId);
        if(atleta is not null)
        {
            return atleta.Attività;
        }
        throw new ArgumentException("L'atleta richiesto non esiste");
    }

    public void ModificaAtleta(Atleta atleta)
    {
        EliminaAtleta(atleta.Id);
        AggiungiAtleta(atleta);
    }
}

//public class GestioneAtletaSQlServer : IGestioneAtleta
//{
//    public void AggiungiAtleta(Atleta atleta)
//    {
//        throw new NotImplementedException();
//    }

//    public void CambiaPesoAdUnAtleta(int atletaId, int nuovoPeso)
//    {
//        throw new NotImplementedException();
//    }

//    public void EliminaAtleta(int atletaId)
//    {
//        throw new NotImplementedException();
//    }

//    public Atleta? EstraiAtleta(int atletaId)
//    {
//        throw new NotImplementedException();
//    }

//    public List<Atleta> EstraiAtleti()
//    {
//        throw new NotImplementedException();
//    }

//    public void ModificaAtleta(Atleta atleta)
//    {
//        throw new NotImplementedException();
//    }
//}

//public class GestioneAtletaServizioRest : IGestioneAtleta
//{
//    public void AggiungiAtleta(Atleta atleta)
//    {
//        throw new NotImplementedException();
//    }

//    public void CambiaPesoAdUnAtleta(int atletaId, int nuovoPeso)
//    {
//        throw new NotImplementedException();
//    }

//    public void EliminaAtleta(int atletaId)
//    {
//        throw new NotImplementedException();
//    }

//    public Atleta? EstraiAtleta(int atletaId)
//    {
//        throw new NotImplementedException();
//    }

//    public List<Atleta> EstraiAtleti()
//    {
//        throw new NotImplementedException();
//    }

//    public void ModificaAtleta(Atleta atleta)
//    {
//        throw new NotImplementedException();
//    }
//}


