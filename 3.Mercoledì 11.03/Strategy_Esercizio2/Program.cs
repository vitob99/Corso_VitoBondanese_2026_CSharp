using System;

class Program
{
    private static int MenuMetodiPagamento()
    {
        Console.WriteLine("[1] Paypal");
        Console.WriteLine("[2] Bitcoin");
        Console.WriteLine("[3] Carta di Credito");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] main)
    {
        PaymentContext pagamento = new PaymentContext();

        int scelta_pagamento = MenuMetodiPagamento();
        Console.Write("Inserisci l'importo da pagare: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            pagamento.ImpostaStrategia(PaymentFactory.CreaPagamento(scelta_pagamento)!);
            pagamento.Pay(amount); 
        }
        else
        {
            Console.WriteLine("Importo non valido!");
        }
    }
}