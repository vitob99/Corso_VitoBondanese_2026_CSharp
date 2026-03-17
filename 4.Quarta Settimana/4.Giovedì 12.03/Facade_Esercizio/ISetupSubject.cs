interface ISetupSubject
{
    void Registra(IObserver observer);
    void Rimuovi(IObserver observer);
    void NotificaStatoPostazione(string stato);
}