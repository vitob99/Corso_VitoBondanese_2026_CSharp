class Artigliere : Fante
{
    private int calibro;
    public int Calibro
    {
        get{return calibro;}
        set{calibro = value;}
    }

    public Artigliere(string nome, string grado, int anni_servizio, string arma, int calibro) : base(nome, grado, anni_servizio, arma)
    {
        this.calibro = calibro;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Calibro: {calibro}");
    }
}