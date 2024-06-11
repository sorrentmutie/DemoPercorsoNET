using Cotrap.Core.Interfacce;

namespace Cotrap.Core.Allenamento;

public class CotrapClock : IClock
{
    public DateTime Now()
    {
        return DateTime.UtcNow;
    }
}

public class FakeMorningClock : IClock
{
    public DateTime Now()
    {
        return new DateTime(2021, 1, 1, 10, 0, 0);
    }
}

public class FakeNightClock : IClock
{
    public DateTime Now()
    {
        return new DateTime(2021, 1, 1, 18, 0, 0);
    }
}
