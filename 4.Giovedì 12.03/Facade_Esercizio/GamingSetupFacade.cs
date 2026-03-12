sealed class GamingSetupFacage : ISetupSubject
{
    public static bool isPostazioneAccesa;
    private List<IObserver> lista_observers = new List<IObserver>();
    private static GamingSetupFacage? postazione;
    private Monitor monitor_gaming;
    private Tastiera tastiera_gaming;
    private Mouse mouse_gaming;
    private SchedaVideo gpu_gaming;

    private GamingSetupFacage()
    {
        Registra(new LogStatoPostazione());
        monitor_gaming = new Monitor();
        tastiera_gaming = new Tastiera();
        mouse_gaming = new Mouse();
        gpu_gaming = new SchedaVideo();
        isPostazioneAccesa = false;
    }

    public static GamingSetupFacage PostazioneGaming
    {
        get
        {
            if(postazione == null)
            {
                postazione = new GamingSetupFacage();
            }
            return postazione;
        }
    }

    public bool AvviaPostazione()
    {
        isPostazioneAccesa = true;
        monitor_gaming.Collega();
        tastiera_gaming.Collega();
        mouse_gaming.Collega();
        gpu_gaming.InizializzaDriverGrafica();
        gpu_gaming.AumentaCoreClock(500);
        gpu_gaming.AumentaMemoryClock(800);
        NotificaStatoPostazione("Accesa");
        return true;
    }

    public void NotificaStatoPostazione(string stato)
    {
        foreach(IObserver o in lista_observers)
        {
            o.AggiornaStatoPostazione(stato);
        }
    }

    public void Registra(IObserver observer)
    {
        lista_observers.Add(observer);
    }

    public void Rimuovi(IObserver observer)
    {
        lista_observers.Remove(observer);
    }

    public bool SpegniPostazione()
    {
        isPostazioneAccesa = false;
        monitor_gaming.Scollega();
        tastiera_gaming.Scollega();
        mouse_gaming.Scollega();
        gpu_gaming.RipristinaDefaultClock();
        NotificaStatoPostazione("Spenta");
        return false;
    }
}