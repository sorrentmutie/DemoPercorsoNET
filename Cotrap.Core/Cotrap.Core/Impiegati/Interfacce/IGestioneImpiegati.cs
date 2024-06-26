using System;
using System.Collections.Generic;

namespace Cotrap.Core.Impiegati.Interfacce;

public interface IGestioneImpiegati
{
    IEnumerable<Impiegato> GetImpiegatiOperativi();
}

