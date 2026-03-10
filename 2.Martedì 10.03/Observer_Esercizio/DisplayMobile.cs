class DisplayMobile : IObserver
{
    public void Aggiorna(string messaggio)
    {
        Console.WriteLine($"Aggiornamento display Mobile: {messaggio}");  //quando avviene il cambiamento sarà eseguito il metodo che aggiorna il display mobile
    }
}