// 5. ConcreteDecoratorB: aggiunge un altro comportamento distinto
public class ConcreteDecoratorB : Decorator
{
    public ConcreteDecoratorB(IComponent component) 
        : base(component) { }

    public override void Operation()
    {
        Console.WriteLine("ConcreteDecoratorB: aggiunta funzionalità prima");
        base.Operation();
    }
}
