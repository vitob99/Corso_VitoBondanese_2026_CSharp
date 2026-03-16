class Fritto : IPreparazioneStrategia
{
    public void Prepara(string descrizione)
    {
        Console.WriteLine($"RISULTATO FINALE => '{descrizione}' fritto con olio!");
    }
}