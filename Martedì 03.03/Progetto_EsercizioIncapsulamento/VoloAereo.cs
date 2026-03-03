class VoloAereo
{
    const int MAX_POSTI = 20;
    private int posti_occupati;
    private int posti_liberi;
    public int codice_volo{set;get;}


    public VoloAereo()
    {
        codice_volo = 0;
        posti_liberi = MAX_POSTI;
        posti_occupati = 0;
    }
    public void EffettuaPrenotazione(int numero_posti)
    {

        if( (numero_posti <= posti_liberi) && (numero_posti > 0))
        {
            posti_liberi -= numero_posti;
            posti_occupati += numero_posti;
            Console.WriteLine($"Hai prenotato {numero_posti} posti con successo!");
        }
        else
        {
            Console.WriteLine($"Non ci sono posti disponibili a sufficienza per {numero_posti} posti richiesti!");
        }
    }

    public void AnnullaPrenotazione(int numero_posti)
    {
        if(( numero_posti > 0) && (numero_posti <= posti_occupati))
        {
            posti_occupati -= numero_posti;
            posti_liberi += numero_posti;
            Console.WriteLine($"Prenotazione di {numero_posti} posti annullata con successo!");
        }
        else
        {
            Console.WriteLine($"Errore: non e' stato possibile annullare la prenotazione per {numero_posti} posti!");
        }
    }

    public void VisualizzaStato()
    {
        Console.WriteLine($"Codice volo: {codice_volo}\nPosti occupati: {posti_occupati}\nPosti liberi: {posti_liberi}");
    }

    public override bool Equals(object? obj)
    {
        if(obj is VoloAereo v2)
        {
            return posti_occupati == v2.posti_occupati && posti_liberi == v2.posti_liberi && codice_volo == v2.codice_volo;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(posti_occupati, posti_liberi, codice_volo);
    }

}