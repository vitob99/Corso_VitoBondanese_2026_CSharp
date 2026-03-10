sealed class GestoreCreazioneUtente : ISoggetto
{
    private static GestoreCreazioneUtente? instance; //singleton
    private List<IObserver> lista_observers;

    public static GestoreCreazioneUtente Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new GestoreCreazioneUtente();
            }
            return instance;
        }
    }
    private GestoreCreazioneUtente()
    {
        lista_observers = new List<IObserver>();
    }

    public void Registra(IObserver o)
    {
        lista_observers.Add(o);
    }

    public void Rimuovi(IObserver o)
    {
        lista_observers.Remove(o);
    }

    public void Notifica(string nomeUtente)
    {
        foreach(IObserver o in lista_observers)
        {
            o.NotificaCreazione(nomeUtente);      //notifica tutti gli observer
        }
    }
    
    public void CreaUtente(string nome)
    {
        UserFactory.Crea(nome); //creo l'utente con il factory...
        Notifica(nome); //...e notifica gli observer
    }
}