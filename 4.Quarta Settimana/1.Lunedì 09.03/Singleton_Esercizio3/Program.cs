using System;

class Program
{
    static void Main(string[] args)
    {
        Logger l1 = Logger.Instance;
        Logger l2 = Logger.Instance;


        string stringa_l1;
        string stringa_l2;
        bool esci = false;
        do
        {
            Console.Clear();
            Console.Write("Aggiungi stringa l1: ");
            stringa_l1 = Console.ReadLine()!;

            Console.Write("Aggiungi stringa l2: ");
            stringa_l2 = Console.ReadLine()!;
            if(stringa_l1.ToLower() == "esci")
            {
                esci = true;
                l2.Log(stringa_l2);
            }
            else if(stringa_l2.ToLower() == "esci")
            {
                esci = true;
                l1.Log(stringa_l1);
            }
            else
            {
                l1.Log(stringa_l1);
                l2.Log(stringa_l2);
            }
        }while(esci == false);

        Logger.Instance.StampaLog(); 
    }
}