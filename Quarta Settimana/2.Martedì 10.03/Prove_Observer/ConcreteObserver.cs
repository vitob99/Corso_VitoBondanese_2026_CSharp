// 4. ConcreteObserver: implementa la logica di reazione alla notifica
public class ConcreteObserver : IObserver
{
    private readonly string _name;
    private int _observerState;

    public ConcreteObserver(string name)
    {
        _name = name;
    }

    // Viene chiamato dal Subject con il nuovo stato
    public void Update(int newState)
    {
        _observerState = newState;
        Console.WriteLine($"{_name} ha ricevuto aggiornamento, stato = {_observerState}");
    }
}