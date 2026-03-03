class Veicolo
{
    private string targa;
    public string Targa
    {
        get{return targa;}
        set{targa = value;}
    }

    public Veicolo(string targa)
    {
        this.targa = targa;
    }

    public virtual void Ripara()
    {
        Console.WriteLine("Il veicolo viene controllato.");
    }
}   
