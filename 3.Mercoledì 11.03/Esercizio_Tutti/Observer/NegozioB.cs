class NegozioB : IObserver //osservatore concreto
{
    public void NotificaPiattoCreato(string descrizione)
    {
        Console.WriteLine($"Negozio B ha ricevuto la preparazione: {descrizione}");
    }
}