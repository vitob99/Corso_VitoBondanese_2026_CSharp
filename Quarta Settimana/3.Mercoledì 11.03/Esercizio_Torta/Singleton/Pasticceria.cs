sealed class Pasticceria : IStockNegozio
{
    private static Pasticceria? instance; //istanza singleton
    private List<IObserver> observers; //lista osservatori, i negozi

    private ITorta? torta_negozio;
    private Pasticceria()
    {
        observers = new List<IObserver>();
    }

    public static Pasticceria Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Pasticceria();
            }
            return instance;
        }
    }
    public void AggiungiTorta(ITorta torta)  //quando aggiungo la torta chiamo Notifica che poi andrà a notificare tutti i negozi dell'aggiunta
    {
        
        torta_negozio = torta;
        Notifica(Instance.torta_negozio!.Descrizione()); 
    }

    public void Registra(IObserver observer)  //aggiungo observer
    {
        observers.Add(observer);
    }

    public void Rimuovi(IObserver observer)  //rimuove observer
    {
        observers.Remove(observer);
    }

    private void Notifica(string torta)  //notifico 
    {
        foreach (IObserver o in observers) 
        {
            o.Aggiorna(torta);
        }
    }


}