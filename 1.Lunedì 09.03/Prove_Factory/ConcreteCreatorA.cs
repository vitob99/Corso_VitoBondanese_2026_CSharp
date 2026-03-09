// 5. ConcreteCreatorA: implementa FactoryMethod per ConcreteProductA
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

// 6. ConcreteCreatorB: implementa FactoryMethod per ConcreteProductB
public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

