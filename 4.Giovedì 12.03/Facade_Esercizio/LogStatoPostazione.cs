class LogStatoPostazione : IObserver
{
    public void AggiornaStatoPostazione(string stato)
    {
        Console.WriteLine($"[{DateTime.Now}] - La postazione e' stata {stato}!");
    }
}