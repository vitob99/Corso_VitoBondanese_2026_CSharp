using System;

class Program
{
    public static void Main(string[] args)
    {
        IVeicolo veicolo;
        bool error = true;
        do
        {
            Console.Clear();
            Console.Write("Veicolo: ");
            try
            {
                veicolo = VeicoloFactory.CreaVeicolo(Console.ReadLine()!);
                error = false;
                veicolo.MostraTipo();
                veicolo.Avvia();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Premi un tasto per continuare...");
                Console.ReadKey();
            }            
        }while(error == true);
    }
}