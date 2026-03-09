using System;

class Program
{
    public static void Main(string[] args)
    {
        bool esci = false;
        do
        {
            Console.Clear();
            Console.Write("Veicolo: ");
            try
            {
                IVeicolo veicolo;
                veicolo = VeicoloFactory.CreaVeicolo(Console.ReadLine()!);
                RegistroVeicoli.Instance.Registra(veicolo);

                Console.WriteLine("Veicolo inserito con successo!");
                RegistroVeicoli.Instance.StampaTutti();
                
                Console.Write("Vuoi inserire un nuovo veicolo? (y/n): ");
                char scelta = char.Parse(Console.ReadLine()!);
                if(char.ToLower(scelta) == 'n')
                {
                    esci = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }    

            Console.Write("Premi un tasto per continuare...");
            Console.ReadKey();        
        }while(esci == false);
    }
}