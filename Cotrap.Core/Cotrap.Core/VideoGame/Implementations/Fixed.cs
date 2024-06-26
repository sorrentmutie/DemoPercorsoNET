using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Fixed : IUpdatable
{
    public void Update()
    {
        Console.WriteLine("Rimango fermo");
    }
}
