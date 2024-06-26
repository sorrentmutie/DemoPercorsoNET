namespace Cotrap.Core.VideoGame.Interfaces;

public interface IUpdatable
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    void Update(int deltaX, int deltaY, int deltaZ);

    void SetInitialPositions(int startingX, int startingY, int startingZ);
}
