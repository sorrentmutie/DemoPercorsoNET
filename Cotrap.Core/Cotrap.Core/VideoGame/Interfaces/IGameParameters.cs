using Cotrap.Core.VideoGame.Implementations;

namespace Cotrap.Core.VideoGame.Interfaces
{
    public interface IGameParameters
    {
        int BorderX { get; set; }
        int BorderY { get; set; }
        int BorderZ { get; set; }

        List<Weapon> weapons { get; set; }
        List<Potion> potions { get; set; }
    }
}