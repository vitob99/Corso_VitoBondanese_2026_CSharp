class Soldato
{
    private string nome;
    private string grado;
    private int anni_servizio;

    public string Nome
    {
        get{return nome;}
        set{nome = value;}
    }

    public string Grado
    {
        get{return grado;}
        set{grado = value;}
    }

    public int AnniServizio
    {
        get{return anni_servizio;}
        set
        {
            if(value >= 0)
            {
                anni_servizio = value;
            }
        }
    }

    public Soldato(string nome, string grado, int anni_servizio)
    {
        this.nome = nome;
        this.grado = grado;
        this.anni_servizio = anni_servizio;
    }

    public virtual void Descrizione()
    {
        Console.WriteLine($"Ruolo: {GetType().Name}\nNome Soldato: {nome}\nGrado Soldato: {grado}\nAnni di servizio: {anni_servizio}");
    }
}