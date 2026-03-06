class Badge
{
    private string codice;
    private bool attivo;
    private DateTime data_creazione;

    public string Codice
    {
        get { return codice; }
    }

    public bool isAttivo
    {
        get { return attivo; }
        set { attivo = value; }
    }

    public DateTime DataCreazione
    {
        get { return data_creazione; }
    }

    public Badge(string codiceIdentificativo, bool stato)
    {
        codice = codiceIdentificativo;
        attivo = stato;
        data_creazione = DateTime.Now;
    }

    public override string ToString()
    {
        string stato = attivo ? "Attivo" : "Disattivato";
        return $"Badge ID:{Codice}\nStato: {stato}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Badge b2)
        {
            return Codice == b2.Codice;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Codice, DataCreazione);
    }
}