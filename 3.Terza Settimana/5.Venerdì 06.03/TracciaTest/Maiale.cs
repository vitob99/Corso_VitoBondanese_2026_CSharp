class Maiale : Animale
{
    bool sporco;
    public bool isSporco
    {
        get{return sporco;}
        set{sporco = value;}
    }

    public Maiale(string nome, int eta, double peso, bool sporco) : base(nome, eta, peso)
    {
        isSporco = sporco;
    }

    public override void EmettiVerso()
    {
        Console.WriteLine("Oink Oink");
    }

    public override void Salta()
    {
        Console.WriteLine("Il maiale non riesce a saltare!");
    }

    public override void Mangia()
    {
        Console.WriteLine("Mangia frutta e fango...");
    }

    public override void Gioca()
    {
        Console.WriteLine("Si rotola nel fango...");
    }

    public override void InfoAnimale()
    {
        base.InfoAnimale();
        Console.WriteLine($"Sporco: {(isSporco ? "Si" : "No")}");
    }
}