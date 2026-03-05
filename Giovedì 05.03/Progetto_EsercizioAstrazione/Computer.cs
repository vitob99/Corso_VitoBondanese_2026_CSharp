class Computer : DispositivoElettronico
{

    public Computer(string modello) : base(modello){}

    public override void Accendi()
    {
        Console.WriteLine("Il computer si avvia...");
    }

    public override void Spegni()
    {
        Console.WriteLine("Il computer si spegne.");
    }
}