using System;

class Program
{
    private static int Menu()
    {
        Console.Clear();
        Console.WriteLine("[1] Notifica utente");
        Console.WriteLine("[2] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static void InserimentoUtente(GestoreCreazioneUtente gestore)
    {
        int n_utenti;
        do
        {

            Console.Clear();
            Console.Write("Quanti utenti vuoi notificare?: ");
            int.TryParse(Console.ReadLine()!, out n_utenti);

            if(n_utenti > 0)
            {
                for(int i = 0; i < n_utenti; i++)
                {
                    string nome_utente;
                    do
                    {
                        Console.Write($"Inserisci il nome del {i + 1}° utente: ");
                        nome_utente = Console.ReadLine()!;
                    }while(nome_utente == "");
                    gestore.CreaUtente(nome_utente); //creo l'utente se il nome non è nullo
                }
            }
        }while(n_utenti <= 0);
        Console.Write("\nInserimento terminato e observer notificati, premi un tasto per continuare...");
        Console.ReadKey();
    }




    public static void Main(string[] args)
    {
        //creo e inizializzo il gestore, aggiungo i due observer
        GestoreCreazioneUtente.Instance.Registra(new ModuloLog());
        GestoreCreazioneUtente.Instance.Registra(new ModuloMarketing());  

        bool esci = false;
        int scelta_menu;
        do
        {
            scelta_menu = Menu();
            switch (scelta_menu)
            {
                case 1:
                    InserimentoUtente(GestoreCreazioneUtente.Instance);
                    break;
                case 2:
                    esci = true;
                    break;
            }
        }while(esci == false);
    }
}