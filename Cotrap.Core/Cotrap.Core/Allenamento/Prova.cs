using Cotrap.Core.Interfacce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotrap.Core.Allenamento
{
    public  class Prova
    {
        private readonly IGestioneAtleta gestioneAtleta;
        private int count = 0;

        public Prova(IGestioneAtleta gestioneAtleta)
        {
            this.gestioneAtleta = gestioneAtleta;
        }

        public void DoSomething()
        {
            var atleti = gestioneAtleta.EstraiAtleti("ros");
            count = atleti.Count();
        }

        // private GestioneAtletaMemoria gestione = new GestioneAtletaMemoria();

    }
}
