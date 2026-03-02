class Veicolo
{
    protected string marca{get;set;}
    protected string modello{get;set;}

    public Veicolo()
    {
        marca = "Marca Default";
        modello = "Modello Default";
    }
    public virtual void StampaInfo()
    {
        Console.WriteLine($"Marca: {marca}\nModello: {modello}");
    }

    public override string ToString()
    {
        return $"Marca: {marca}\nModello: {modello}";
    }

    public override bool Equals(object? obj)
    {
        if(obj is Veicolo v2)
        {
            return marca == v2.marca && modello == v2.modello;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(marca, modello);
    }
}