using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public abstract class GameElement : IVisible, ICollidable, IUpdatable
{
    private readonly IVisible visible;
    private readonly ICollidable collidable;
    private readonly IUpdatable updatable;

    public GameElement(IVisible visible, ICollidable collidable,
         IUpdatable updatable)
    {
        this.visible = visible;
        this.collidable = collidable;
        this.updatable = updatable;
    }

    public void Collide()
    {
       collidable.Collide();
    }

    public void Paint()
    {
        visible.Paint();
    }

    public void Update()
    {
        updatable.Update();
    }
}

public class Warrior: GameElement
{
    public Warrior(IVisible visible, ICollidable collidable,
         IUpdatable updatable) : base(visible, collidable, updatable)
    {
    }
}