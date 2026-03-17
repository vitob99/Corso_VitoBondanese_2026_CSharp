using System;

class Program
{
    public static void Main()
    {
        ContoBancario conto = new ContoBancario();

        conto.Saldo = 1000.50; // imposta il saldo tramite la proprietà
        Console.WriteLine(conto.Saldo); // legge il saldo tramite la proprietà

        conto.Saldo = 500; // non modifica il saldo che è negativo
        Console.WriteLine(conto.Saldo); // rimane 1000.50
    }
}
