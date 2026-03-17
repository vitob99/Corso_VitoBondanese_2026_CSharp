// 4. ConcreteStrategyMultiply: implementa la moltiplicazione
public class ConcreteStrategyMultiply : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a * b;
    }
}