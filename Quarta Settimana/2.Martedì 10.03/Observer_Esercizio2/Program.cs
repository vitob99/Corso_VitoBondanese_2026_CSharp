using System;
using System.ComponentModel.Design;

class Program
{
    public static void Main(string[] args)
    {
        NewsAgency.Instance.AggiungiOsservatore(new MobileApp());
        NewsAgency.Instance.AggiungiOsservatore(new EmailClient());

        string news;
        bool esci = false;
        do
        {
            Console.Write("Nuova news: ");
            news = Console.ReadLine()!;
            if(news.ToLower() == "esci" || (news.ToLower() == ""))
            {
                esci = true;
                //nessuna notifica se esco
            }
            else
            {
                NewsAgency.Instance.News = news;
            }
           
        }while(esci == false);
    }
}