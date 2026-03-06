class Camion : Veicolo
{
    public Camion(string targa) : base(targa){}

    public override void Ripara()
    {
        base.Ripara();
        Console.WriteLine("Controllo sospensioni, freni rinforzati e carico del camion.");
    }
}