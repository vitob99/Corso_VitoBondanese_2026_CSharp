using System;
using System.Diagnostics;

class Program
{
    private static int MenuSceltaBevanda()
    {
        Console.Clear();
        Console.WriteLine("[1] Caffe'");
        Console.WriteLine("[2] Te'");
        Console.WriteLine("[3] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static int MenuSceltaAggiunte()
    {
        Console.Clear();
        Console.WriteLine("[1] Cioccolato");
        Console.WriteLine("[2] Panna");
        Console.WriteLine("[3] Latte");
        Console.WriteLine("[4] Totale");
        Console.WriteLine("[5] Indietro");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    
    public static void Main(string[] args)
    {
      

        bool esci = false;
        int scelta_bevanda;
        do
        {
            scelta_bevanda = MenuSceltaBevanda();
            switch (scelta_bevanda)
            {
                case 1:
                    Caffe caf = new Caffe();
                    double tot_caf = 0;

                    Console.WriteLine($"Costo base Caffe': {caf.Costo()}");
                    int scelta_aggiunta;
                    bool esci_aggiunta = false;
                    do
                    {
                        scelta_aggiunta = MenuSceltaAggiunte();
                        switch (scelta_aggiunta)
                        {
                            case 1: //aggiunta cioccolato
                                Console.Clear();
                         

                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break;
                            case 2: //aggiunta panna
                                Console.Clear();
                            

                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break; 
                            case 3:   //aggiunta latte
                              
                                

                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break;
                            case 4:  //totale
                                Console.Clear();
                                Console.WriteLine("TOTALE");
                                if(tot_caf == 0)
                                {
                                    Console.WriteLine($"Totale Caffe': {caf.Costo()}$");
                                }
                                else
                                {
                                    Console.WriteLine($"Totale Caffe': {tot_caf}$");
                                }
                                

                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break;
                            case 5: //indietro
                                esci_aggiunta = true;
                                break;
                        }
                    }while(esci_aggiunta == false);
                    break;
                case 2:
                    break;
                case 3:
                    esci = true;
                    break;
            }

        }while(esci == false);



        //manca l'aggiunta dinamica a scelta
        Caffe c = new Caffe();

        Console.WriteLine($"Costo del caffe': {c.Costo()}$");
        Console.WriteLine($"Descrizione: {c.Descrizione()}\n");

        IBevanda decorator1 = new ConPanna(c);
        Console.WriteLine(decorator1.Descrizione());
        Console.WriteLine($"{decorator1.Costo()}$\n");

        IBevanda decorator2 = new ConCioccolato(decorator1);
        Console.WriteLine(decorator2.Descrizione());
        Console.WriteLine($"{decorator2.Costo()}$");
    }
}