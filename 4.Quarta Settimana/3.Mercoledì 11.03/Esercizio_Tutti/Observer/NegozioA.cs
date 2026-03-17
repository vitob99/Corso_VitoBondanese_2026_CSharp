class NegozioA : IObserver  //osservatore concreto
{
    public void NotificaPiattoCreato(string descrizione)
    {
        Console.WriteLine($"Negozio A ha ricevuto la preparazione: {descrizione}");
    }
}