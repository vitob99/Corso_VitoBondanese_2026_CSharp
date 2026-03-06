class Dipendente : Persona
{
    private string matricola;

    public string Matricola
    {
        get { return matricola; }
        set { matricola = value; }
    }

    public Dipendente(string nome, string cognome, string codice_fiscale, Badge badge_accesso, string matricola) : base(nome, cognome, codice_fiscale, badge_accesso)
    {
        this.matricola = matricola;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Matricola: {matricola}");
    }
    public override string ToString()
    {
        return $"{base.ToString()}\nMatricola: {Matricola}";
    }

    public override bool Equals(object? obj)  //confronto con il codice fiscale perchè è univoco
    {
        if (obj is Persona p2)
        {
            return CodiceFiscale == p2.CodiceFiscale;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Cognome, CodiceFiscale);
    }
}