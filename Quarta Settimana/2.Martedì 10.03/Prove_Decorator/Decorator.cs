// 3. Decorator: classe astratta che implementa IComponent 
//    e incapsula un IComponent interno
public abstract class Decorator : IComponent
{
    // Riferimento al componente "decorato"
    protected IComponent _component;

    // Costruttore: richiede un componente da decorare
    protected Decorator(IComponent component)
    {
        _component = component;
    }

    // Delegazione dell'operazione al componente interno
    public virtual void Operation()
    {
        _component.Operation();
    }
}