class AlForno : IPreparazioneStrategia
{
    public void Prepara(string descrizione)
    {
        Console.WriteLine($"RISULTATO FINALE => '{descrizione}' messo nel forno!");
    }
}