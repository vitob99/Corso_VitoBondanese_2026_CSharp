class OperatoreEmergenza : Operatore
{   
    private int livello_urgenza;
    public int LivelloUrgenza
    {
        get{return livello_urgenza;}
        set
        {
            if(value >= 1 && value <= 5)
            {
                livello_urgenza = value;
            }
        }
    }
    public OperatoreEmergenza(string nome, string turno, int livello_urgenza) : base(nome, turno)
    {
        LivelloUrgenza = livello_urgenza;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Gestione emergenza di livello {livello_urgenza}");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nLivello emergenza: {livello_urgenza}";
    }
}