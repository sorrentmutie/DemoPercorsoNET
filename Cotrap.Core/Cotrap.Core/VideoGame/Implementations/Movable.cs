using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class Movable: IUpdatable
{
    private readonly IGameParameters gameParameters;

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Movable(IGameParameters gameParameters)
    {
        this.gameParameters = gameParameters;        
    }



    public void Update(int deltaX, int deltaY, int deltaZ)
    {
        X = NewPosition(deltaX, X, gameParameters.BorderX);
        Y = NewPosition(deltaY, Y, gameParameters.BorderY);
        Z = NewPosition(deltaZ, Z, gameParameters.BorderZ);

        int NewPosition(int deltaX, int X, int borderX)
        {
            bool segno = X > 0;
            var newX = X + deltaX;

            if (segno)
            {
                if (Math.Abs(newX) <= borderX)
                {
                    return X += deltaX;
                }
                else
                {
                    return borderX;
                }
            }
            else
            {
                if (Math.Abs(newX) <= borderX)
                {
                    return X += deltaX;
                }
                else
                {
                    return -borderX;
                }
            }
        }

            
    }

    public void SetInitialPositions(int startingX, int startingY, int startingZ)
    {
        X = CheckInitialPosition(startingX, gameParameters.BorderX);
        Y = CheckInitialPosition(startingY, gameParameters.BorderY);
        Z = CheckInitialPosition(startingZ, gameParameters.BorderZ);

        int CheckInitialPosition(int startingX, int limiteX)
        {
            if (Math.Abs(startingX) > limiteX)
            {
                return 0;
            }
            else
            {
                return startingX;
            }
        }
    }
}
