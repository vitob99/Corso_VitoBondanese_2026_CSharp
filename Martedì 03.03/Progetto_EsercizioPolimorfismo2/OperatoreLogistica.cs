class OperatoreLogistica : Operatore
{
    private int numero_consegne;
    public int NumeroConsegne
    {
        get{return numero_consegne;}
        set
        {
            if(value >= 0)
            {
                numero_consegne = value;
            }
        }
    }

    public OperatoreLogistica(string nome, string turno, int numero_consegne) : base(nome, turno)
    {
        this.numero_consegne = numero_consegne;
    }

    public override void EseguiCompito()
    {
        Console.WriteLine($"Coordinamento di {numero_consegne} consegne");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nNumero consegne: {numero_consegne}";
    }
}