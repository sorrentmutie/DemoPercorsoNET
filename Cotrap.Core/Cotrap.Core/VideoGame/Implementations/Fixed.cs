using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Fixed : IUpdatable
{
    private readonly IGameParameters gameParameters;

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Fixed(IGameParameters gameParameters)
    {
        this.gameParameters = gameParameters;
    }
    public void Update(int deltaX, int deltaY, int deltaZ)
    {
        
    }

    public void SetInitialPositions(int startingX, int startingY, int startingZ)
    {
        X = startingX;
        Y = startingY;
        Z = startingZ;
    }
}
