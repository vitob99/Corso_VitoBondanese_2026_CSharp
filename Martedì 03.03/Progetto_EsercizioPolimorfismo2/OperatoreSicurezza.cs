class OperatoreSicurezza : Operatore
{
    private string area_sorvegliata;
    public string AreaSorvegliata
    {
        get{return area_sorvegliata;}
        set{area_sorvegliata = value;}
    }

    public OperatoreSicurezza(string nome, string turno, string area_sorvegliata) : base(nome, turno)
    {
        this.area_sorvegliata = area_sorvegliata;
    }
    public override void EseguiCompito()
    {
        Console.WriteLine($"Sorveglianza dell'area {area_sorvegliata}");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nArea sorvegliata: {area_sorvegliata}";
    }
}