using Cotrap.Core;
using Cotrap.Core.AnalisiTesto;


Console.WriteLine("Ciao");
var x = Utility.MioMinimo(5, 6);
var y = Utility.MioMinimo("ciao", "mondo"); 

Console.WriteLine(y);


void DoSomething()
{
    //Studente s = new Studente();
    // s.Nome = "Mario";
    //var s = new Studente { Nome = "Mario" };

    //var t = new { Nome = "Mario", Cognome = "Rossi" };  
    var numeri = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var numeriMaggioriCinque = numeri.MioFindSpeciale();
    var numeriMaggioriSette = numeri.MioFindSpeciale2(7);
    var numeriMaggioriOtto = numeri.MioSuperFind(NumeroSpeciale);

}

bool NumeroSpeciale(int n)
{
    return n > 8;
}


int Somma(int a, int b)
{
    return a + b;
}

int SommaQuadratica(int a, int b)
{
    return a*a + b*b;
}

Func<int, int, int> somma = SommaQuadratica;
int risultato = somma(5, 6);

List<int> MiaLista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var numeriPari = MiaLista.FindAll(NumeroPari);
// Predicate<int>
// public delegate bool Predicate<T> (T obj);
//bool NumeroPari(int x)
//{
//    return x % 2 == 0;
//}

//var numeriPari = MiaLista.FindAll(delegate(int n) { return n % 2 == 0; });
//var numeroPari = MiaLista.FindAll( (int n) => { return n % 2 == 0; } );
//var numeroPari = MiaLista.FindAll( n => { return n % 2 == 0; });
var numeroPari = MiaLista.FindAll(n =>  n % 2 == 0);

class Utility
{
    public static T MioMinimo<T>(T a, T b) where T : IComparable<T>
    {
        if (a.CompareTo(b) < 0)
        {
            return a;
        }
        return b;
    }
}

//public delegate TResult Func<T1,T2, TResult> (T1 arg1, T2 arg2);



public class Studente
{
    private string? _nome;
    public string? Nome     {
        get
        {
            return _nome;
        }
        set
        {
            _nome = value;
        }
    }


    //public string Nome { get; set; }
    
}

public static class MieEstensioni
{
    public static List<int> MioFindSpeciale(this List<int> lista)
    {
        return lista.FindAll(n => n > 5);
    }

    public static List<int> MioFindSpeciale2(this List<int> lista, int soglia)
    {
        return lista.FindAll(n => n > soglia);
    }

    public static List<int> MioSuperFind(this List<int> lista, Predicate<int> mioFunc)
    {
        return lista.FindAll(mioFunc);
    }

    
}



