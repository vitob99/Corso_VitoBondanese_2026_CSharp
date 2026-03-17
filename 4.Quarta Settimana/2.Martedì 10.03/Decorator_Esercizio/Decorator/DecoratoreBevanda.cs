abstract class DecoratoreBevanda : IBevanda
{
    protected IBevanda bevanda_decorator;

    public DecoratoreBevanda(IBevanda bevanda_da_decorare)
    {
        bevanda_decorator = bevanda_da_decorare;
    }
    
    public abstract double Costo();
    public abstract string Descrizione();
    
}