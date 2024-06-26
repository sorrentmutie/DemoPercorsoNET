using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Visible : IVisible
{
    public void Paint()
    {
        Console.WriteLine("Appaio sullo schermo"); 
    }
}
