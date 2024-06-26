using Cotrap.Core.VideoGame.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Cotrap.Core.VideoGame.Implementations;

public abstract class GameElement : IVisible, ICollidable, IUpdatable
{
    private readonly IVisible visible;
    private readonly ICollidable collidable;
    private readonly IUpdatable updatable;
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public GameElement(IVisible visible, ICollidable collidable, IUpdatable updatable)
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

    public void Update(int deltaX, int deltaY, int deltaZ)
    {
        updatable.Update(deltaX, deltaY, deltaZ);
        X = updatable.X;
        Y = updatable.Y;
        Z = updatable.Z;
    }

    public void SetInitialPositions(int startingX, int startingY, int startingZ)
    {
        updatable.SetInitialPositions(startingX, startingY, startingZ);
        X = updatable.X;
        Y = updatable.Y;
        Z = updatable.Z;
    }
}

public class Warrior: GameElement
{
    public List<Weapon> listaArmi { get; set; } = new();
    public Warrior(IVisible visible, ICollidable collidable, IUpdatable updatable) : base(visible, collidable, updatable)
    {
        base.X = X;
        base.Y = Y;
        base.Z = Z;
    }

    public void CheckWeapon(IGameParameters gameParameters)
    {
        foreach (Weapon weapon in gameParameters.weapons)
        {
            if(weapon.X == this.X && weapon.Y == this.Y && weapon.Z == this.Z)
            {
                listaArmi.Add(weapon);
            }
        }

    }
     
    
}

public class Weapon: IUpdatable
{
    private readonly IUpdatable updatable;

    public string Name { get; set; }
    public int Value { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Weapon(IUpdatable updatable)
    {
        this.updatable = updatable;
    }

    public void SetInitialPositions(int startingX, int startingY, int startingZ)
    {
        updatable.SetInitialPositions(startingX, startingY, startingZ);
        X = startingX;
        Y = startingY;
        Z = startingZ;
    }

    public void Update(int deltaX, int deltaY, int deltaZ)
    {
        updatable.Update(deltaX, deltaY, deltaZ);
        X = updatable.X;
        Y = updatable.Y;
        Z = updatable.Z;
    }
}



public class Potion : IUpdatable
{
    private readonly IUpdatable updatable;

    public string Name { get; set; } = string.Empty;
    public int Value { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Potion(IUpdatable updatable)
    {
        this.updatable = updatable;
    }
    public void SetInitialPositions(int startingX, int startingY, int startingZ)
    {
        updatable.SetInitialPositions(startingX, startingY, startingZ);
        X = startingX;
        Y = startingY;
        Z = startingZ;
    }

    public void Update(int deltaX, int deltaY, int deltaZ)
    {
        updatable.Update(deltaX, deltaY, deltaZ);
        X = updatable.X;
        Y = updatable.Y;
        Z = updatable.Z;
    }
}



public class Priest : GameElement
{
    public List<Potion> listaPozioni { get; set; } = new();
    public Priest(IVisible visible, ICollidable collidable, IUpdatable updatable) : base(visible, collidable, updatable)
    {
        base.X = X;
        base.Y = Y;
        base.Z = Z;
    }

    public void CheckPotions(IGameParameters gameParameters)
    {
        foreach (Potion pozione in gameParameters.potions)
        {
            if (pozione.X == this.X && pozione.Y == this.Y && pozione.Z == this.Z)
            {
                listaPozioni.Add(pozione);
            }
        }

    }
}



public class Prince : GameElement
{
    public List<Weapon> listaArmi { get; set; } = new();
    public List<Potion> listaPozioni { get; set; } = new();

    public Prince(IVisible visible, ICollidable collidable, IUpdatable updatable) : base(visible, collidable, updatable)
    {
        base.X = X;
        base.Y = Y;
        base.Z = Z;
    }

    public void CheckWeaponsAndPotions(IGameParameters gameParameters)
    {
        foreach (Potion pozione in gameParameters.potions)
        {
            if (pozione.X == this.X && pozione.Y == this.Y && pozione.Z == this.Z)
            {
                listaPozioni.Add(pozione);
            }
        }

        foreach (Weapon weapon in gameParameters.weapons)
        {
            if (weapon.X == this.X && weapon.Y == this.Y && weapon.Z == this.Z)
            {
                listaArmi.Add(weapon);
            }
        }

    }
}