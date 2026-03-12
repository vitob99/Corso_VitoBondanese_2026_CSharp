class Monitor : IDispositivo
{
    public void Collega()
    {
        Console.WriteLine("Monitor Collegato!");
    }

    public void InizializzaDriver()
    {
        Console.WriteLine("Driver Monitor inizializzati!");
    }

    public void Scollega()
    {
        Console.WriteLine("Monitor Scollegato!");
    }
}