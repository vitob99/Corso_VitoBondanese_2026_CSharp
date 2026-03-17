using System;

class Program
{
    private static int MenuDispositivi()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci un computer");
        Console.WriteLine("[2] Inserisci una stampante");
        Console.WriteLine("[3] Elenco dispositivi");
        Console.WriteLine("[4] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] args)
    {
        List<DispositivoElettronico> dispositivi = new List<DispositivoElettronico>();

        bool esci_menu_dispositivi = false;
        int scelta_menu_dispositivi;
        do
        {
            scelta_menu_dispositivi = MenuDispositivi();
            switch (scelta_menu_dispositivi)
            {
                case 1:  //inserisci computer
                    Console.Clear();
                    Console.Write("Modello computer: ");
                    string modello_computer = Console.ReadLine()!;
                    dispositivi.Add(new Computer(modello_computer));
                    Console.WriteLine($"Modello di computer '{modello_computer}' aggiunto con successo!");
                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2:   //inserisci stampante
                    Console.Clear();
                    Console.Write("Modello stampante: ");
                    string modello_stampante = Console.ReadLine()!;
                    dispositivi.Add(new Stampante(modello_stampante));
                    Console.WriteLine($"Modello di stampante '{modello_stampante}' aggiunto con successo!");
                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:  //lista dispositivi
                    Console.Clear();
                    Console.WriteLine("LISTA DISPOSITIVI");
                    int n_dispositivi = dispositivi.Count;
                    if(n_dispositivi > 0)
                    {
                        foreach(DispositivoElettronico d in dispositivi)
                        {
                            d.MostraInfo();
                            d.Accendi();
                            d.Spegni();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non e' presente alcun dispositivo!");
                    }
                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 4:
                    esci_menu_dispositivi = true;
                    break;
            }

        }while(esci_menu_dispositivi == false);
    }
}