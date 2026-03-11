class NegozioRoma : IObserver
{
    public void Aggiorna(string torta)
    {
        Console.WriteLine($"{torta} aggiornata a Roma!");
    }
}