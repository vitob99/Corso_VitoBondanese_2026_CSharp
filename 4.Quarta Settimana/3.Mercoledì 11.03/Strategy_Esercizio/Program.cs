using System;

class Program
{
    private static int MenuSceltaOperazione(int n1, int n2)
    {
        Console.Clear();
        Console.WriteLine($"Scegli una operazione da eseguire con i numeri '{n1}' e '{n2}'");
        Console.WriteLine("[1] Addizione");
        Console.WriteLine("[2] Sottrazione");
        Console.WriteLine("[3] Moltiplicazione");
        Console.WriteLine("[4] Divisione");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static void SetNumeri(ref int n1, ref int n2)
    {
        Console.Clear();
        Console.Write("Primo numero: ");
        n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Secondo numero: ");
        n2 = int.Parse(Console.ReadLine()!);
    }

    private static int MenuNumeri()
    {
        Console.Clear();
        Console.WriteLine("[1] Imposta numeri");
        Console.WriteLine("[2] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    public static void Main(string[] args)
    {
        Calcolatrice c = new Calcolatrice();
        c.Registra(new OperazioneUsata()); //assegno un observer al context della strategy "c"
        
        double risultato;
        int scelta_operazione;
        int scelta_menu_numeri;
        bool esci = false;
        int n1 = 0;
        int n2 = 0;

        do
        {
            scelta_menu_numeri = MenuNumeri();
            switch (scelta_menu_numeri)
            {
                case 1:
                    SetNumeri(ref n1, ref n2);
                    scelta_operazione = MenuSceltaOperazione(n1,n2);
                    switch (scelta_operazione)  //eseguo lo switch sulla scelta dal menu operazioni...
                    {
                        case 1: //addizione 
                            c.ImpostaStrategia(new SommaStrategia());   //...in base alla scelta assegno una strategy
                            break;
                        case 2:  //sottrazione
                            c.ImpostaStrategia(new SottrazioneStrategia());
                            break;
                        case 3: //moltiplicazione
                            c.ImpostaStrategia(new MoltiplicazioneStrategia());
                            break;
                        case 4: //divisione
                            c.ImpostaStrategia(new DivisioneStrategia());
                            break;
                    }
                    risultato = c.EseguiOperazione(n1, n2);
                    Console.WriteLine($"Risultato: {risultato}");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2:
                    esci = true;
                    break;
            }
        }while(esci == false);

    }
}