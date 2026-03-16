class SchedaVideo
{
    const double BASE_CORE_CLOCK = 1000d;
    const double BASE_MEMORY_CLOCK = 2000d;

    private double core_clock;
    private double memory_clock;

    public SchedaVideo()
    {
        core_clock = BASE_CORE_CLOCK;
        memory_clock = BASE_MEMORY_CLOCK;
    }

    public double CoreClock
    {
        get{return core_clock;}
    }
    public double MemoryClock
    {
        get{return memory_clock;}
    }

    public void InizializzaDriverGrafica()
    {
        Console.WriteLine("Driver grafici inizializzati!");
    }

    public void AumentaCoreClock(double mhz)
    {
        Console.Write($"Core clock ({core_clock} mhz) aumentato (+{mhz} mhz) => ");
        core_clock += mhz;
        Console.WriteLine($"Core Clock = {core_clock} mhz");
    }

    public void AumentaMemoryClock(double mhz)
    {
        Console.Write($"Memory clock ({memory_clock} mhz) aumentato (+{mhz} mhz) => ");
        memory_clock += mhz;
        Console.WriteLine($"Memory Clock = {memory_clock} mhz");
    }

    public void RipristinaDefaultClock()
    {
        core_clock = BASE_CORE_CLOCK;
        memory_clock = BASE_MEMORY_CLOCK;
        Console.WriteLine("Core clock e Memory clock ripristinati alle impostazioni predefinite...");
        Console.WriteLine($"Core clock: {core_clock} - Memory clock: {memory_clock}");
    }
}