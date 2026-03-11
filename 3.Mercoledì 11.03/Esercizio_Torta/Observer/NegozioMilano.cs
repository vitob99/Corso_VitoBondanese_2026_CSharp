class NegozioMilano : IObserver
{
    public void Aggiorna(string torta)
    {
        Console.WriteLine($"{torta} aggiornata a Milano!");
    }
}