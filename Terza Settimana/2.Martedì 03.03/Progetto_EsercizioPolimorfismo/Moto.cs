class Moto : Veicolo
{
    public Moto(string targa) : base(targa){}

    public override void Ripara()
    {
        base.Ripara();
        Console.WriteLine("Controllo catena, freni e gomme della moto.");
    }
}