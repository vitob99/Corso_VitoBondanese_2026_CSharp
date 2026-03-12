class Mouse : IDispositivo
{
    public void Collega()
    {
        Console.WriteLine("Mouse collegato!");
    }

    public void InizializzaDriver()
    {
        Console.WriteLine("Driver Mouse avviati!");
    }

    public void Scollega()
    {
        Console.WriteLine("Mouse Scollegato!");
    }
}