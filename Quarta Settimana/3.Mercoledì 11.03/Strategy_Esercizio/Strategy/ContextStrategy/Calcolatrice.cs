class Calcolatrice : ICalcolatrice
{
    private List<IObserver> lista_observers; //lista osservatori
    IStrategiaOperazione? strategia;

    
    public Calcolatrice()
    {
        lista_observers = new List<IObserver>();
    }
    public double EseguiOperazione(double a, double b){
        return strategia!.Calcola(a, b);
    }

    public void ImpostaStrategia(IStrategiaOperazione nuovaStrategia){
        strategia = nuovaStrategia;
        Notifica(nuovaStrategia.NomeOperazione());  //appena imposto la strategia avvio il metodo Notifica che "avviserà" gli observer 
    }

    public void Notifica(string nome_operazione)
    {
        foreach(IObserver o in lista_observers)
        {
            o.Aggiorna(nome_operazione);
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
}