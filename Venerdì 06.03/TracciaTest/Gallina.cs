class Gallina : Animale
{
    int numero_uova;
    public int NumeroUova
    {
        get{return numero_uova;}
        set
        {
            if(value >= 0)
            {
                numero_uova = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public Gallina(string nome, int eta, double peso, int numero_uova): base(nome, eta, peso)
    {
        NumeroUova = numero_uova;
    }

    public override void EmettiVerso()
    {
        Console.WriteLine("Chicchirichiii");
    }

    public override void Salta()
    {
        Console.WriteLine("La gallina salta e inizia a planare!");
    }

    public override void Mangia()
    {
        Console.WriteLine("Mangia mais...");
    }

    public override void Gioca()
    {
        if(NumeroUova > 20)
        {
            Console.WriteLine("Fa rotolare le sue vuova...");
        }
        else
        {
            Console.WriteLine("Ha poche uova quindi non gioca...");
        }
    }

    public override void InfoAnimale()
    {
        base.InfoAnimale();
        Console.WriteLine($"Numero uova: {NumeroUova}");
    }
}