class Auto : Veicolo
{
    public int numero_porte{get;set;}

    public Auto()
    {
        numero_porte = 4;
    }
    public override void StampaInfo()
    {
        base.StampaInfo();
        Console.WriteLine($"Numero Porte: {numero_porte}");
        Console.WriteLine();
    }
}