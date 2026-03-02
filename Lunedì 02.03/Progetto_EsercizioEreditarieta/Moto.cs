class Moto : Veicolo
{
    public string tipo_manubrio{get;set;}

    public Moto() : base()
    {
        tipo_manubrio = "Tipo Default";
    }
    public override void StampaInfo()
    {
        base.StampaInfo(); //stampo le info generali per un veicolo
        Console.WriteLine($"Tipo Manubrio: {tipo_manubrio}");
        Console.WriteLine();
    }
}