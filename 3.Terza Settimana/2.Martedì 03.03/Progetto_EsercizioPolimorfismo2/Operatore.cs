class Operatore
{
    private string nome;
    private string turno;

    public string Nome
    {
        get{return nome;}
        set{nome = value;}
    }

    public string Turno
    {
        get{return nome;}
        set{turno = value;}
    }

    public Operatore(string nome, string turno)
    {
        this.nome = nome;
        this.turno = turno;
    }
    public virtual void EseguiCompito()
    {
        Console.WriteLine("Operatore generico in servizio.");
    }

    public override string ToString()
    {
        return $"Nome Operatore: {nome}\nTurno: {turno}";
    }

    public override bool Equals(object? obj)
    {
        if(obj is Operatore o2)
        {
            return nome == o2.Nome && turno == o2.Turno;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(nome, turno);
    }
}