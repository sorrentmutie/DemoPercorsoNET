using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Movable: IUpdatable
{
    public void Update()
    {
        Console.WriteLine("Mi muovo");
    }
}
