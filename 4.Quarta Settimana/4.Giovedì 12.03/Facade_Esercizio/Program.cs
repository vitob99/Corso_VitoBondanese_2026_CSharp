using System;
using System.ComponentModel.Design;

class Program
{
    private static int MenuPostazione()
    {
        Console.Clear();
        Console.WriteLine("[1] Avvia postazione");
        Console.WriteLine("[2] Spegni postazione");
        Console.WriteLine("[3] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] args)
    {
        bool esci = false;
        int scelta;
        do{
            scelta = MenuPostazione();
            switch (scelta)
            {
                case 1:
                    if (!GamingSetupFacage.isPostazioneAccesa)
                    {
                        Console.Clear();
                        GamingSetupFacage.PostazioneGaming.AvviaPostazione();
                        
                        Console.Write("\nPremi un tasto per continuare...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Postazione gia' accesa!");
                        Console.Write("\nPremi un tasto per continuare...");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    if (GamingSetupFacage.isPostazioneAccesa)
                    {
                        Console.Clear();
                        GamingSetupFacage.PostazioneGaming.SpegniPostazione();
                        
                        Console.Write("\nPremi un tasto per continuare...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Postazione gia' spenta!");
                        Console.Write("\nPremi un tasto per continuare...");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    esci = true;
                    break;
            }
        }while(esci == false);
    }
}