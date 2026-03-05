class LogAccesso
{
    private DateTime data_ora_entrata;
    private Persona persona;
    private DateTime data_ora_uscita;

    public DateTime DataOraEntrata
    {
        get{return DataOraEntrata;}
    }
    public Persona Persona
    {
        get{return persona;}
    }

    public LogAccesso(Persona persona)
    {
        data_ora_entrata = DateTime.Now; //per ora solo con data entrata;
        this.persona = persona;
    }

    public override string ToString()
    {
        return $"[{DataOraEntrata:dd/MM/yyyy HH:mm:ss}] => Codice badge: {persona.BadgeAccesso.Codice} | Figura: {persona.GetType().Name} | Nome: {persona.Nome} | Cognome: {persona.Cognome} | Codice Fiscale: {persona.CodiceFiscale}";
    }
}