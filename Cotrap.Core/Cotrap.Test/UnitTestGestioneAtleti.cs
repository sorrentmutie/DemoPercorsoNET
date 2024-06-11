using Cotrap.Core.Allenamento;

namespace Cotrap.Test
{
    [TestClass]
    public class UnitTestGestioneAtleti
    {
        [TestMethod]
        public void GestioneOspitiMattino()
        {
            var myClock = new FakeMorningClock();
            var ospiti = new GestioneOspitiDatabase(myClock);
            var gestione = new GestioneAtletaMemoria(ospiti);

            var atleti = gestione.EstraiAtleti();
            Assert.AreEqual(5, atleti.Count());

        }

        [TestMethod]
        public void GestioneOspitiSera()
        {
            var myClock = new FakeNightClock();
            var ospiti = new GestioneOspitiDatabase(myClock);
            var gestione = new GestioneAtletaMemoria(ospiti);

            var atleti = gestione.EstraiAtleti();
            var kimjong = atleti.FirstOrDefault(a => a.Nome == "Kim" && a.Cognome == "Jong");

            // Assert.AreEqual(6, atleti.Count());
            Assert.IsNotNull(kimjong);

        }

        [TestMethod]
        public void CambiaPeso()
        {
            var myClock = new FakeNightClock();
            var ospiti = new GestioneOspitiDatabase(myClock);
            var gestione = new GestioneAtletaMemoria(ospiti);

            gestione.CambiaPesoAdUnAtleta(1, 70);
            var atleta = gestione.EstraiAtleti().FirstOrDefault(a => a.Id == 1);
            if(atleta is not null)
            {
                Assert.AreEqual(70, atleta.Peso);
            } else
            {
                Assert.Inconclusive();

            }

        }

        [TestMethod]
        public void Sovrappeso()
        {
            var myClock = new FakeNightClock();
            var ospiti = new GestioneOspitiDatabase(myClock);
            var gestione = new GestioneAtletaMemoria(ospiti);

            //gestione.CambiaPesoAdUnAtleta(1, 200);
            //var atleta = gestione.EstraiAtleti().FirstOrDefault(a => a.Id == 1);
            Assert.ThrowsException<Exception>(() => gestione.CambiaPesoAdUnAtleta(1, 200));
            //if (atleta is not null)
            //{
                
            //  //Assert.AreNotEqual(200, atleta.Peso);
            //}
            //else
            //{
            //    Assert.Inconclusive();

            //}

        }


    }
}