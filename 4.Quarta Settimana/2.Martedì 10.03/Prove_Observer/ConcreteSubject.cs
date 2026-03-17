// 3. ConcreteSubject: implementa ISubject e mantiene lo stato osservato
public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private int _state;

    // Proprietà dello stato; quando cambia, notifica gli observer
    public int State
    {
        get => _state;
        set
        {
            _state = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_state);
        }
    }
}