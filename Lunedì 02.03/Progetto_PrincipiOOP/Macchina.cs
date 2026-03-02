class Macchina
{
    public const int COSTO_SOSPENSIONI = 2;
    public const int COSTO_MOTORE = 2;
    public const int COSTO_VELOCITA = 5;


    public string motore{get; set;}
    public int sospensioni_max{get; set;}
    public float velocita_max{get; set;}
    public int nr_modifiche{get; set;}


    public Macchina()
    {
        motore = "Default";
        sospensioni_max = 5;
        velocita_max = 50.0f;
        nr_modifiche = 0;
    }

    public override string ToString()
    {
        return $"Motore: {motore}\nSospensioni: {sospensioni_max}\nVelocita' massima: {velocita_max}\nNumero modifiche: {nr_modifiche}";
    }

    public override bool Equals(object? m)
    {
        if(m is Macchina m2)
        {
            return motore == m2.motore && sospensioni_max == m2.sospensioni_max && velocita_max == m2.velocita_max && nr_modifiche == m2.nr_modifiche;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(motore, sospensioni_max, velocita_max, nr_modifiche);
    }
}