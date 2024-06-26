using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Invisible : IVisible
{
    public void Paint()
    {
        Console.WriteLine("Non appaio sullo schermo");
    }
}
