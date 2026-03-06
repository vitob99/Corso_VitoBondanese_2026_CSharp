using System;

class Program
{
    private static int MenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Aggiungere un nuovo Fante");
        Console.WriteLine("[2] Aggiungere un nuovo Artigliere");
        Console.WriteLine("[3] Visualizzare tutti i soldati con Descrizione()");
        Console.WriteLine("[0] Uscire");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] args)
    {
        List<Soldato> plotone = new List<Soldato>();
        
        bool esci = false;
        int scelta_menu;
        do
        {
            scelta_menu = MenuPrincipale();
            switch (scelta_menu)
            {
                // 'out' per gli inserimenti ocn funzione a parte
                case 1: //aggiunta fante
                    Console.Clear();
                    Console.Write("Nome fante: ");
                    string nome_fante = Console.ReadLine()!;
                    Console.Write("Grado fante: ");
                    string grado_fante = Console.ReadLine()!;
                    Console.Write("Anni di servizio: ");
                    int anni_servizio_fante = int.Parse(Console.ReadLine()!);
                    Console.Write("Arma: ");
                    string arma_fante = Console.ReadLine()!;

                    plotone.Add(new Fante(nome_fante, grado_fante, anni_servizio_fante, arma_fante));
                    Console.WriteLine($"Fante '{nome_fante}' aggiunto con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2: //aggiunta artigliere
                    Console.Clear();
                    Console.Write("Nome artigliere: ");
                    string nome_artigliere = Console.ReadLine()!;
                    Console.Write("Grado fante: ");
                    string grado_artigliere = Console.ReadLine()!;
                    Console.Write("Anni di servizio: ");
                    int anni_servizio_artigliere = int.Parse(Console.ReadLine()!);
                    Console.Write("Arma: ");
                    string arma_artigliere = Console.ReadLine()!;
                    Console.Write("Calibro: ");
                    int calibro_arma_artigliere = int.Parse(Console.ReadLine()!);

                    plotone.Add(new Artigliere(nome_artigliere, grado_artigliere, anni_servizio_artigliere, arma_artigliere, calibro_arma_artigliere));
                    Console.WriteLine($"Artigliere '{nome_artigliere}' aggiunto con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:  //visualizza descrizione
                    Console.Clear();
                    Console.WriteLine("LISTA SOLDATI");
                    Console.WriteLine();
                    foreach(Soldato s in plotone)
                    {
                        s.Descrizione();
                        Console.WriteLine();
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 0: //esci
                    esci = true;
                    break;

            }
        }while(esci == false);
        
        Console.WriteLine();
        Esercito e = new Esercito();
        e.ElencoSoldati(plotone);
    }
}