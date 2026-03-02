using System;

class Program
{
    private static int sceltaMenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci Veicolo");
        Console.WriteLine("[2] Mostra Veicoli");
        Console.WriteLine("[3] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static int sceltaMenuTipoVeicolo()
    {
        Console.Clear();
        Console.WriteLine("[1] Auto");
        Console.WriteLine("[2] Moto");
        Console.WriteLine("[3] Indietro");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] args)
    {
        List<Veicolo> lista_veicoli = new  List<Veicolo>();
        lista_veicoli.Add(new Auto());
        lista_veicoli.Add(new Auto());
        lista_veicoli.Add(new Moto());
        lista_veicoli.Add(new Moto());

        bool esci = false;
        int scelta;
        do
        {
            bool indietro = false;
            scelta = sceltaMenuPrincipale();
            switch (scelta)
            {
                case 1:
                    int scelta_veicolo;
                    do
                    {
                        scelta_veicolo = sceltaMenuTipoVeicolo();
                        switch (scelta_veicolo)
                        {
                            case 1: 
                                lista_veicoli.Add(new Auto());
                                Console.WriteLine("Aggiunta una nuova auto!");
                                Console.Write("Premi un testo per continuare...");
                                Console.ReadKey();
                                break;
                            case 2:
                                lista_veicoli.Add(new Moto());
                                Console.WriteLine("Aggiunta una nuova moto!");
                                Console.Write("Premi un testo per continuare...");
                                Console.ReadKey();
                                break;
                            case 3:
                                indietro = true;
                                break;
                        }
                    }while(indietro == false);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("LISTA VEICOLI");
                    foreach(Veicolo v in lista_veicoli)
                    {
                        v.StampaInfo();
                    }
                    Console.Write("Premi un testo per continuare...");
                    Console.ReadKey();
                    break;
                case 3:
                    esci = true;
                    break;
            }
        }while(esci == false);



    }
}