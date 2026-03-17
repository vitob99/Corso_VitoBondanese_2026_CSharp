// 3. ConcreteStrategySubtract: implementa la sottrazione
public class ConcreteStrategySubtract : IStrategy
{
    public int DoOperation(int a, int b)
    {
        return a - b;
    }
}