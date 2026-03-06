class Pecora : Animale
{
    bool tosata;
    public bool isTosata
    {
        get{return tosata;}
        set{tosata = value;}
    }

    public Pecora(string nome, int eta, double peso, bool tosata) : base(nome, eta, peso)
    {
        isTosata = tosata;
    }

    public override void EmettiVerso()
    {
        Console.WriteLine("Beeeeehhh");
    }

    public override void Salta()
    {
        Console.WriteLine("La pecora salta di 2 centimetri!");
    }

    public override void Mangia()
    {
        Console.WriteLine("Mangia erba...");
    }

    public override void Gioca()
    {
        Console.WriteLine("La pecora corre e rotola sull'erba...");
    }

    public override void InfoAnimale()
    {
        base.InfoAnimale();
        Console.WriteLine($"Tosata: {(isTosata ? "Si" : "No")}");
    }
}