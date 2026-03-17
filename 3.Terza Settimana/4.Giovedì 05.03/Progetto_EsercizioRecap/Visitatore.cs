class Visitatore : Persona
{
    private Dipendente referente; 

    public Dipendente Referente 
    {
        get { return referente; }
        set { referente = value; }
    }

    public Visitatore(string nome, string cognome, string codice_fiscale, Badge badge_accesso, Dipendente referente) : base(nome, cognome, codice_fiscale, badge_accesso)
    {
        this.referente = referente;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Referente: {Referente.Nome} {Referente.Cognome}";
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