abstract class DispositivoElettronico
{
    public string Modello { get; set; }

    public DispositivoElettronico(string modello)
    {
        Modello = modello;
    }
    
    public abstract void Accendi();
    public abstract void Spegni();

    public virtual void MostraInfo()
    {
        Console.WriteLine($"Modello: {Modello}");
    }

}