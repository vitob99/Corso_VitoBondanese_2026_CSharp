sealed class NewsAgency
{
    private static NewsAgency? instance;
    private List<INewsSubscriber> subscriber_osservatori = new List<INewsSubscriber>();
    private string news;

    private NewsAgency(){news = "";}

    public static NewsAgency Instance
    {
        get
        {
            if (instance == null)
                instance = new NewsAgency();
            return instance;
        }
    }

    public string News
    {
        get{return news;}
        set
        {
            news = value;
            NotifySubscribers();
            //rilevo la modifica a 'news' e chiamo il metodo di notifica agli observer
        }
    }

    private void NotifySubscribers()
    {
        foreach (INewsSubscriber subscriber in subscriber_osservatori)
        {
            subscriber.AggiornaNotifica(news);
        }
    }

    public void AggiungiOsservatore(INewsSubscriber subscriber)
    {
        subscriber_osservatori.Add(subscriber);
    }

    public void RimuoviOsservatore(INewsSubscriber subscriber){
        subscriber_osservatori.Remove(subscriber);
    }
}