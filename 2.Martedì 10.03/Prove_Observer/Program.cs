using System;

// 5. Client: crea il subject e alcuni observer, e modella cambi di stato
class Program
{
    static void Main()
    {
        var subject = new ConcreteSubject();

        var observerA = new ConcreteObserver("Observer A");
        var observerB = new ConcreteObserver("Observer B");

        // Registrazione degli observer
        subject.Attach(observerA);
        subject.Attach(observerB);

        // Cambia lo stato: innesca Notify() e chiama Update() su tutti gli observer
        subject.State = 5;
        subject.State = 10;

        // Rimuove un observer
        subject.Detach(observerA);

        // Ancora un cambiamento di stato: solo Observer B verrà notificato
        subject.State = 15;
    }
}