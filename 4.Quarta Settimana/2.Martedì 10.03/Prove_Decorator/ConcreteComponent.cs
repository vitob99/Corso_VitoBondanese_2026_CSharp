// 2. ConcreteComponent: oggetto base senza decorazioni
public class ConcreteComponent : IComponent
{
    public void Operation()
    {
        Console.WriteLine("ConcreteComponent: operazione di base");
    }
}