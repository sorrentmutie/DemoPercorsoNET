using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Solid : ICollidable
{
    public void Collide()
    {
        Console.WriteLine("Bang!"); 
    }
}
