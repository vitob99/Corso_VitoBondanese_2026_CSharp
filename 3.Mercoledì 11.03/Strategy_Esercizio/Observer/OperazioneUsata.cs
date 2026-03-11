class OperazioneUsata : IObserver
{
    public void Aggiorna(string nome_operazione)
    {
        Console.WriteLine($"E' stata usata l'operazione {nome_operazione}");
    }
}