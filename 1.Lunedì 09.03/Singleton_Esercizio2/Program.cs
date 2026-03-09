using System;

class Program
{
    private static int menuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Aggiungi configurazione Modulo A");
        Console.WriteLine("[2] Aggiungi configurazione Modulo B");
        Console.WriteLine("[3] Stampa tutte le configurazioni");
        Console.WriteLine("[4] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
   
    static void Main(string[] args)
    {
        bool esci = false;
        int scelta;
        do
        {
            scelta = menuPrincipale();
            switch (scelta)
            {
                case 1:
                    Console.Clear();
                    ConfigurazioneSistema modulo_a = ConfigurazioneSistema.Instance;
                    Console.Write("Modulo A - Inserisci Chiave: ");
                    string chiave_a = Console.ReadLine()!;
                    Console.Write("Modulo A - Inserisci Valore: ");
                    string valore_a = Console.ReadLine()!;
                    modulo_a.Imposta(chiave_a, valore_a);
                    break;
                case 2:
                    Console.Clear();
                    ConfigurazioneSistema modulo_b = ConfigurazioneSistema.Instance;
                    Console.Write("Modulo B - Inserisci Chiave: ");
                    string chiave_b = Console.ReadLine()!;
                    Console.Write("Modulo B - Inserisci Valore: ");
                    string valore_b = Console.ReadLine()!;
                    modulo_b.Imposta(chiave_b, valore_b);
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("LISTA CONFIGURAZIONI");

                    //stampo tutte le coppie del dizionario dell'istanza, stamperà sia le coppie aggiunte dal modulo a che quelle aggiunte del modulo b
                    ConfigurazioneSistema.Instance.StampaTutte(); 

                    Console.Write("Premi un testo per continuare...");
                    Console.ReadKey();
                    break;
                case 4:
                    esci = true;
                    break;
            }
        }while (esci == false);
    }
}