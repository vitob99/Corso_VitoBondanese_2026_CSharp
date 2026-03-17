class Tastiera : IDispositivo
{
    public void Collega()
    {
        Console.WriteLine("Tastiera Collegata!");
    }

    public void InizializzaDriver()
    {
        Console.WriteLine("Driver Mouse avviati!");
    }

    public void Scollega()
    {
        Console.WriteLine("Tastiera Scollegata!");
    }
}