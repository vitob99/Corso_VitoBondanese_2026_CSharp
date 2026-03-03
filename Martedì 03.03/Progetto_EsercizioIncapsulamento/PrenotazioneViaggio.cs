class PrenotazioneViaggio
{
    const int MAX_POSTI = 20;

    private int posti_prenotati;
    private string destinazione;
    

    public PrenotazioneViaggio(string destinazione)
    {
        this.destinazione = destinazione;
        posti_prenotati = 0;
    }

    public int PostiDisponibili
    {
        get
        {
            return MAX_POSTI - posti_prenotati;
        }
    }
    public string Destinazione
    {
        get
        {
            return destinazione;
        }
        set
        {
            destinazione = value;
        }
    }
    public int PostiPrenotati
    {
        get
        {
            return posti_prenotati;
        }
    }





    public void PrenotaPosti(int numero)
    {
        if(numero <= (MAX_POSTI - posti_prenotati))
        {
            posti_prenotati += numero;
        }
    }

    public void AnnullaPrenotazione(int numero)
    {
        if(numero >= 0 && (posti_prenotati - numero) >= 0)
        {
            posti_prenotati -= numero;
        }
    }

    public override string ToString()
    {
        return $"Destinazione: {destinazione}\nPosti prenotati: {posti_prenotati}\nPosti disponibili: {PostiDisponibili}";
    }

    public override bool Equals(object? obj)
    {
        if(obj is PrenotazioneViaggio p2)
        {
            return posti_prenotati == p2.posti_prenotati && destinazione == p2.Destinazione;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(posti_prenotati, destinazione);
    }
}