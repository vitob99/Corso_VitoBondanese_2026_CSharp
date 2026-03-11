// 2. ConcreteStrategyAdd: implementa la somma
public class ConcreteStrategyAdd : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a + b;
    }
}