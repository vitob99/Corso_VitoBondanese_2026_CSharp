
// 5. Context: utilizza una strategia per eseguire l'operazione
public class Context
{
    // Riferimento alla strategia corrente
    private IStrategy? _strategy;

    // Permette di cambiare strategia a runtime
    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    // Esegue l'algoritmo tramite la strategia corrente
    public void ExecuteStrategy(int a, int b)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Nessuna strategia impostata.");
            return;
        }
        int result = _strategy.DoOperation(a, b);
        Console.WriteLine($"Risultato dell'operazione: {result}");
    }
}