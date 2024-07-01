using Cotrap.Core.VideoGame.Implementations;
using Cotrap.Core.VideoGame.Interfaces;

namespace Cotrap.Test;

[TestClass]
public class UnitTestGame
{
    IGameParameters gameParameters = new GameParameters();
    IVisible visible = new Visible();
    ICollidable collidable = new Solid();
    IUpdatable updatable;
    Warrior heman;
    Priest priest;
    Prince prince;


    public UnitTestGame()
    {
        updatable = new Movable(gameParameters);

        var spada = new Weapon(updatable) { Name = "Spada", Value = 100 };
        spada.SetInitialPositions(10, 10, 10);
        var lancia = new Weapon(updatable) { Name = "Lancia", Value = 120 };
        lancia.SetInitialPositions(5, 5, 5);
        var weapons = new List<Weapon> { spada, lancia };
        gameParameters.weapons = weapons;


        var pozione1 = new Potion(updatable) { Name = "pozione1", Value = 100};
        var pozione2 = new Potion(updatable) { Name = "pozione2", Value = 10 };
        pozione1.SetInitialPositions(2, 2, 2);
        pozione2.SetInitialPositions(6, 7, 8);
        var potions = new List<Potion> { pozione1, pozione2 };
        gameParameters.potions = potions;

        heman = new Warrior(visible, collidable, updatable);
        priest = new Priest(visible, collidable, updatable);
        prince = new Prince(visible, collidable, updatable);
    }

    [TestMethod]
    public void ControlloPosizioneIniziale()
    {
        heman.SetInitialPositions(102, 1000, 890);
        Assert.AreEqual(0, heman.X);
    }


    [TestMethod]
    public void ControlloRaggiungimentoParetePerElementoSpostabile()
    {
        heman.SetInitialPositions(99, 0, 0); 
        heman.Update(2, 0, 0);
       

        Assert.AreEqual(100, heman.X);
    }

    [TestMethod]
    public void ControlloRaggiungimentoParetePerElementoSpostabileConCoordinateNegative()
    {
        heman.SetInitialPositions(-99, 0, 0);
        heman.Update(-2, 0, 0);


        Assert.AreEqual(-100, heman.X);
    }

    [TestMethod]
    public void ControlloRaggiungimentoParetePerElementoSpostabileConCoordinateNegativeRandom()
    {
        heman.SetInitialPositions(-75, 0, 0);
        heman.Update(-2, 0, 0);


        Assert.AreEqual(-77, heman.X);
    }

    [TestMethod]
    public void ControlloRaggiungimentoParetePerElementoSpostabileConCoordinatePositiveRandom()
    {
        heman.SetInitialPositions(75, 0, 0);
        heman.Update(-2, 0, 0);


        Assert.AreEqual(73, heman.X);
    }

    [TestMethod]
    public void ControlloRaggiungimentoParetePerElementoSpostabileConCoordinateAZero()
    {
        heman.SetInitialPositions(0, 0, 0);
        heman.Update(-2, 0, 0);


        Assert.AreEqual(-2, heman.X);
    }

    [TestMethod]
    public void ControlloArma()
    {
        heman.SetInitialPositions(8, 10, 10);
        heman.Update(2, 0, 0);
        heman.CheckWeapon(gameParameters);
        Assert.AreEqual(1, heman.listaArmi.Count());
    }


    [TestMethod]
    public void ControlloPozione()
    {
        priest.SetInitialPositions(0, 2, 2);
        priest.Update(2, 0, 0);
        priest.CheckPotions(gameParameters);
        Assert.AreEqual(1, priest.listaPozioni.Count());
    }


    [TestMethod]
    public void ControlloPozionePrincipe()
    {
        prince.SetInitialPositions(100, 100, 100);
        prince.Update(-90, -90, -90);
        prince.CheckWeaponsAndPotions(gameParameters);
        Assert.AreEqual(0, prince.listaPozioni.Count());
        Assert.AreEqual(1, prince.listaArmi.Count());
    }
}
