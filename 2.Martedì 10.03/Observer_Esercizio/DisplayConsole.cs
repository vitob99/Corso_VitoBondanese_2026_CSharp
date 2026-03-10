class DisplayConsole : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento display Console: {messaggio}"); //quando avviene il cambiamento sarà eseguito il metodo che aggiorna il display console
    }
}