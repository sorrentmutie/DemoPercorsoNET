using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Core.VideoGame.Implementations;

public class GameParameters : IGameParameters
{
    public int BorderX { get; set; } = 100;
    public int BorderY { get; set; } = 100;
    public int BorderZ { get; set; } = 100;
    public List<Weapon> weapons { get; set; } = new();
    public List<Potion> potions { get; set; } = new();
}
