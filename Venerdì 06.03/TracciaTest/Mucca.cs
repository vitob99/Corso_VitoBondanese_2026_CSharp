class Mucca : Animale
{
    int numero_macchie;
    public int NumeroMacchie
    {
        get{return numero_macchie;}
        set
        {
            if(value >= 0)
            {
                numero_macchie = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public Mucca(string nome, int eta, double peso, int numero_macchie) : base(nome, eta, peso)
    {
        NumeroMacchie = numero_macchie;
    }

    public override void EmettiVerso()
    {
        Console.WriteLine("Muuuuuu");
    }

    public override void Salta()
    {
        if(Peso > 100)
        {
            Console.WriteLine("La mucca non riesce a saltare!");
        }
        else
        {
            Console.WriteLine("La mucca salta!");
        }
    }

    public override void Mangia()
    {
        Console.WriteLine("Mangia erba in mucchese...");
    }

    public override void Gioca()
    {
        Console.WriteLine("Corre e spruzza latte...");
    }

    public override void InfoAnimale()
    {
        base.InfoAnimale();
        Console.WriteLine($"Numero macchie: {NumeroMacchie}");
    }
}