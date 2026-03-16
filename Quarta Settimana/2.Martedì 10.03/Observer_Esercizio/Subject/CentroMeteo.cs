class CentroMeteo : ISoggetto
{
    private List<IObserver> lista_observer;

    public CentroMeteo()
    {
        lista_observer = new List<IObserver>();
    }
    public void Notifica(string messaggio) //notifico tutti gli osservatori del CentroMeteo, in questo caso i Display
    {
        foreach (var observer in lista_observer)
        {
            observer.Aggiorna(messaggio);
        }
    }

    public void Registra(IObserver osservatore) //aggiunge un osservatore alla lista degli osservatori per lo stato di CentroMeteo
    {
        lista_observer.Add(osservatore);
    }

    public void Rimuovi(IObserver osservatore)  //toglie osservatore dalla lista degli osservatori per lo stato di CentroMeteo
    {
        lista_observer.Remove(osservatore);
    }





    public void AggiornaMeteo(string dati)  //quando chiamato l'aggiornamento, verrà chiamato il metodo Notifica(string dati) con i dati ricevuti 
    {
        Console.WriteLine($"Meteo aggiornato con {dati}");
        Notifica(dati); //avvia la notifica
    }


}