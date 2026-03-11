using System;
using System.Collections.Generic;

// 6. Client: configura il contesto e usa diverse strategie
class Program
{
    static void Main()
    {
        var context = new Context();

        // Usa la strategia di somma
        context.SetStrategy(new ConcreteStrategyAdd());
        Console.Write("Somma: ");
        context.ExecuteStrategy(10, 5);  // Output: 15

        // Cambia strategia in sottrazione
        context.SetStrategy(new ConcreteStrategySubtract());
        Console.Write("Sottrazione: ");
        context.ExecuteStrategy(10, 5);  // Output: 5

        // Cambia strategia in moltiplicazione
        context.SetStrategy(new ConcreteStrategyMultiply());
        Console.Write("Moltiplicazione: ");
        context.ExecuteStrategy(10, 5);  // Output: 50
    }
}