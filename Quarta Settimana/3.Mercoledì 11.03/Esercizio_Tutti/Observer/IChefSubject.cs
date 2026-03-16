interface IChefSubject
{
    void Registra(IObserver o);
    void Rimuovi(IObserver o);
    void Notifica(string descrizione);
}