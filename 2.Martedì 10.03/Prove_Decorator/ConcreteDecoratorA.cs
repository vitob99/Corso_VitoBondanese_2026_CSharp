// 4. ConcreteDecoratorA: aggiunge comportamento prima e dopo la chiamata
public class ConcreteDecoratorA : Decorator
{
    public ConcreteDecoratorA(IComponent component) 
        : base(component) { }

    public override void Operation()
    {
        Console.WriteLine("ConcreteDecoratorA: pre‑operazione");
        base.Operation();  // chiama Operation() sul componente interno
        Console.WriteLine("ConcreteDecoratorA: post‑operazione");
    }
}