// 4. Creator: dichiara il Factory Method
public abstract class Creator
{
    // Factory Method: restituisce un IProduct
    public abstract IProduct FactoryMethod();

    // Un metodo del creator che utilizza il prodotto
    public void AnOperation()
    {
        IProduct product = FactoryMethod();
        product.Operation();
    }
}
