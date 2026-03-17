// 2. Subject: interfaccia che permette di aggiungere/rimuovere observer e notificare
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}