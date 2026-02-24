using System;
using System.Security.Authentication;

class Program
{
    private static int contaOccorrenze(List<int> l, int i)
    {
        int n = 0;
        foreach(int intero in l)
        {
            if(intero == i)
            {
                n++;
            }
        }
        return n;
    }    public static void Main(string[] args)
    {
        //LISTE
        List<string> nomi = new List<string>();
        nomi.Add("Mario");
        nomi.Add("Luca");
        //List<string> nomi = ["Mario", "Luca"];



        /*
            1. Scrivi un programma che:
                a.Crea una lista di interi vuota.
                b.Chiede all’utente di inserire 5 numeri interi.
                c.Aggiunge i numeri nella lista.
                d.Chiede e rimuove uno o più numeri dalla lista.
                e.Stampa tutti i numeri presenti in lista.
        */
        List<int> lista_interi = new List<int>();
        const int NUMERI = 5;
        for(int i = 0; i < NUMERI; i++)
        {
            Console.Write($"{i + 1}° Elemento: ");
            lista_interi.Add(int.Parse(Console.ReadLine()));
        }

        bool ripeti_rimuovi = true;
        do{
            Console.Write("Rimuovi un intero: ");
            int intero = int.Parse(Console.ReadLine());
            if (lista_interi.Remove(intero))
            {
                Console.WriteLine($"L'elemento {intero} e' stato rimosso con successo");
            }
            else
            {
                Console.WriteLine($"Errore: l'elemento {intero} non e' presente nella lista!");
            }
            Console.Write("Vuoi rimuovere un altro elemento? (y/n): ");
            char scelta = char.Parse(Console.ReadLine());
                if(scelta == 'n')
                {
                    ripeti_rimuovi = false;
                }
        }while(ripeti_rimuovi);

        foreach(int n in lista_interi)
        {
            Console.WriteLine(n);
        }
        /*
            2.Scrivi un programma che:
                a.Genera una lista di 10 numeri casuali tra 1 e 100.
                b.Stampa la lista.
                c.Chiede all’utente un numero da cercare.
                d.Controlla se il numero è presente nella lista e stampa la posizione (indice), oppure un messaggio se non trovato.
                e.Restituisce tutti i numeri pari (quanti e quali sono).
        */
        const int N_ELEMENTI = 10;
        List<int> lista_casuale = new List<int>();
        Random r = new Random();
        for(int i = 0; i < N_ELEMENTI; i++)
        {
            lista_casuale.Add(r.Next(1, 100));
        }
        
        foreach(int n in lista_casuale)
        {
            Console.WriteLine($"- {n}");
        }

        Console.Write("Numero da cercare: ");
        int intero_cercato = int.Parse(Console.ReadLine());

        if (lista_casuale.Contains(intero_cercato)){
            Console.WriteLine($"Posizione dell'elemento '{intero_cercato}' => {lista_casuale.IndexOf(intero_cercato)}");
        }
        else
        {
            Console.WriteLine($"Errore: l'elemento '{intero_cercato}' non e' stato trovato");
        }

        List<int> lista_pari = new List<int>();
        foreach(int n in lista_casuale)
        {
            if(n % 2 == 0)
            {
                lista_pari.Add(n);
            }
        }

        Console.WriteLine($"Ci sono {lista_pari.Count} elementi pari: ");
        foreach(int n in lista_pari)
        {
            Console.WriteLine($"- {n}");
        }
        /*
            3.Scrivi un programma che:
                a.Crea una lista di interi con almeno 15 numeri casuali tra 1 e 20 (quindi con possibili duplicati).
                b.Stampa la lista originale.
                c.Rimuove i duplicati mantenendo solo i valori unici.
                d.Ordina la lista in ordine crescente.
                e.Stampa la lista finale senza duplicati e ordinata
        */
        List<int> lista_casuali2 = new List<int>();
        const int N_ELEMENTI2 = 15;
        for(int i = 0; i < N_ELEMENTI2; i++)
        {
            lista_casuali2.Add(r.Next(1, 100));
        }


        Console.WriteLine($"List originale: {lista_casuali2.Count} elementi!");
        foreach(int n in lista_casuali2)
        {
            Console.WriteLine($"- {n}");
        }


        for (int i = lista_casuali2.Count - 1; i >= 0; i--)
        {
            if (lista_casuali2.IndexOf(lista_casuali2[i]) != i)
            {       
                lista_casuali2.RemoveAt(i);
            }
        }
        lista_casuali2.Sort();



        Console.WriteLine($"Lista ordinata senza dupliati: {lista_casuali2.Count} elementi!");
        foreach(int n in lista_casuali2)
        {
            Console.WriteLine($"- {n}");
        }
    }
    

}