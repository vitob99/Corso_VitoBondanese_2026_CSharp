class Persona
{
    private string nome;
    private string cognome;
    private string codice_fiscale;
    private Badge badge_accesso;

    public string Nome 
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cognome 
    {
        get { return cognome; }
        set { cognome = value; }
    }

    public string CodiceFiscale 
    {
        get { return codice_fiscale; }
        set { codice_fiscale = value; }
    }

    public Badge BadgeAccesso
    {
        get{return badge_accesso;}
    }
    
    public Persona(string nome, string cognome, string codice_fiscale, Badge badge_accesso)
    {
        this.nome = nome;
        this.cognome = cognome;
        this.codice_fiscale = codice_fiscale;
        this.badge_accesso = badge_accesso;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Nome: {Nome}\nCognome: {Cognome}\nCodice fiscale: {CodiceFiscale}\nID Badge: {badge_accesso.Codice}");
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nCognome: {Cognome}\nCodice fiscale: {CodiceFiscale}";
    }

    public override bool Equals(object? obj)
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