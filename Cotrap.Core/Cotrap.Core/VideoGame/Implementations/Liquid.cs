using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Liquid: ICollidable
{
    public void Collide()
    {
        Console.WriteLine("Splash");
    }
}

