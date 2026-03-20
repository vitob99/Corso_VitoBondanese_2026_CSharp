class GreetingService
{
    private readonly IGreeter dipendenza;

    public GreetingService(IGreeter dipendenza)
    {
        this.dipendenza = dipendenza;
    }

    public void StampaMessaggio(string messaggio)
    {
        dipendenza.Greet(messaggio);
    }
}