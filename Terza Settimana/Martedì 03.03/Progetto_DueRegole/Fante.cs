class Fante : Soldato
{
    private string arma;
    public string Arma
    {
        get{return arma;}
        set{arma = value;}
    }

    public Fante(string nome, string grado, int anni_servizio, string arma) : base(nome, grado, anni_servizio)
    {
        this.arma = arma;
    }

    public override void Descrizione()
    {
        base.Descrizione();
        Console.WriteLine($"Arma: {arma}");
    }
}