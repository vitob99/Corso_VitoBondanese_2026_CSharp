class AllaGriglia : IPreparazioneStrategia
{
    public void Prepara(string descrizione)
    {
        Console.WriteLine($"RISULTATO FINALE => '{descrizione}' grigliato sulla fornacella!");
    }
}