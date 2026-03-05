class LogAccesso
{
    private DateTime data_ora;
    private Persona persona;


    public DateTime DataOra
    {
        get{return data_ora;}
    }
    public Persona Persona
    {
        get{return persona;}
    }

    public LogAccesso(Persona persona)
    {
        this.data_ora = DateTime.Now;
        this.persona = persona;
    }

    public override string ToString()
    {
        return $"[{data_ora:dd/MM/yyyy HH:mm:ss}] => Codice badge: {persona.BadgeAccesso.Codice} | Figura: {persona.GetType().Name} | Nome: {persona.Nome} | Cognome: {persona.Cognome} | Codice Fiscale: {persona.CodiceFiscale}";
    }
}