//classe base
class Animale
{
    protected int eta;
    public void FaiVerso()
    {
        Console.WriteLine("L'animale fa un verso.");
    }

    public void Mangia()
    {
        Console.WriteLine("L'animale mangia.");
    }

    public virtual void Verso()
    {
        Console.WriteLine("L'animale emette un verso.");
    }
}

