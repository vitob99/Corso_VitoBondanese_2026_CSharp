using System;
// Esempio di utilizzo (Client)
class Program
{
    static void Main()
    {
        // Oggetto di base
        IComponent component = new ConcreteComponent();
        Console.WriteLine("Client: chiamata diretta al ConcreteComponent:");
        component.Operation();

        // Decoro con A
        IComponent decoratorA = new ConcreteDecoratorA(component);
        Console.WriteLine("\nClient: ConcreteComponent decorato con A:");
        decoratorA.Operation();

        // Decoro con A poi B (catena di decorator)
        IComponent decoratorB = new ConcreteDecoratorB(decoratorA);
        Console.WriteLine("\nClient: ConcreteComponent decorato con A e poi B:");
        decoratorB.Operation();
    }
}