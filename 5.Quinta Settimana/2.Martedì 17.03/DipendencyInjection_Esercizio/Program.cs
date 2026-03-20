using System;

class Program
{
    public static void Main(string[] args)
    {
        //Esercizio 1
        IGreeter dipendenza = new ConsoleGreeter();
        GreetingService g = new GreetingService(dipendenza);
        g.StampaMessaggio("Ciao a tutti!");


        //Esercizio 2
        IPaymentGateway modalita_pagamento = null!;
        PaymentProcessor pagamento;
        int scelta;
        bool esci = false;
        do
        {
            Console.Clear();
            Console.WriteLine("[1] Pagamento con PayPal");
            Console.WriteLine("[2] Pagamento con Carta");
            Console.WriteLine("[3] Esci");
            Console.Write("Scegli: ");
            if(int.TryParse(Console.ReadLine(), out scelta))
            {
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Scelto il pagamento con PayPal!");
                        modalita_pagamento = new PaypalGateway();
                        pagamento = new PaymentProcessor(modalita_pagamento!);
                        pagamento.EseguiPagamento(200.50f);

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey(); 
                        break;
                    case 2:
                        Console.WriteLine("Scelto il pagamento con Carta di Credito!");
                        modalita_pagamento = new CreditCardGateway();
                        pagamento = new PaymentProcessor(modalita_pagamento!);
                        pagamento.EseguiPagamento(200.50f);

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey(); 
                        break;
                    case 3:
                        esci = true;
                        break;
                    default:
                        break;
                }                
            }
        }while(esci == false);

    }
}