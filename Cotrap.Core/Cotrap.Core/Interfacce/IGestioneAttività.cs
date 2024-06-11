using Cotrap.Core.Allenamento;

namespace Cotrap.Core.Interfacce;

public interface IGestioneAttività
{
    void AggiungiAttività(Attività attività, int idAtleta);
    List<Attività> EstraiAttività(int atletaId);
}
