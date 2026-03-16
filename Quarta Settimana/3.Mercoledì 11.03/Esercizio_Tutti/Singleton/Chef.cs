sealed class Chef : IChefSubject
{
    //classe cardine
    private List<IObserver> lista_osservatori; //lista osservatori
    private static Chef? instance; //istanza singleton
    private IPreparazioneStrategia? strategia_preparazione; //strategia di preparazione
    private Chef()
    {
        lista_osservatori = new List<IObserver>();
    }

    public static Chef Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new Chef();
            }
            return instance;
        }
    }

    public void ImpostaStrategia(IPreparazioneStrategia nuovaStrategia) //imposta la strategia di preparazione
    {
        strategia_preparazione = nuovaStrategia;
    }
        
    public void PreparaPiatto(IPiatto piatto)  //viene eseguita la strategia
    {
        Instance.Notifica(piatto.Descrizione()); //notifica agli observer della preparazione
        strategia_preparazione!.Prepara(piatto.Descrizione());
    }

    public void Registra(IObserver o)
    {
        lista_osservatori.Add(o);
    }

    public void Rimuovi(IObserver o)
    {
        lista_osservatori.Remove(o);
    }

    public void Notifica(string descrizione)  //avvisa tutti gli observer del cambiamento
    {
        foreach(IObserver o in lista_osservatori)
        {
            o.NotificaPiattoCreato(descrizione);
        }
    }
}