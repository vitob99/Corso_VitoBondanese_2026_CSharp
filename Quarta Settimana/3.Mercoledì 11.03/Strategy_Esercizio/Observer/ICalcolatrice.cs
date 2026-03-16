interface ICalcolatrice
{
    void Registra(IObserver observer);
    void Rimuovi(IObserver observer);
    void Notifica(string nome_operazione);
}