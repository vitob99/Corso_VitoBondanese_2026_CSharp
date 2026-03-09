using System;
class Program
{
   public static void Main(string[] args)
    {
        //TEST SINGLETON
        Singleton x = Singleton.Instance;
        x.DoSomething();

        //ESERCIZIO SINGLETON 1
        Console.WriteLine("LOGGER");
        Logger l = Logger.GetIstanza();
        Logger2 l2 = Logger2.GetIstanza();
        string msg;
        do
        {
            Console.Write("Messaggio: ");
            msg = Console.ReadLine()!;
            l.ScriviMessaggio(msg);
            Console.WriteLine($"Stessa istanza? => {l == Logger.GetIstanza()}");
            
            Console.WriteLine("LOGGER 2");
            l2.GetDataOggi();
        }while(msg.ToLower() != "esci");

        
    } 
}
