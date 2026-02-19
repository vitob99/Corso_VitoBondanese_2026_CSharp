using System;

class Program
{
    private static int risultato_potenza; //variabile visibile "globalmente" in sola e tutta la classe
    /*
    1. Scrivi un metodo StampaSaluto che riceve come parametro una stringa 
    con il nome dell’utente e stampa un saluto personalizzato.
    */
    private static void StampaSaluto(string nomeUtente, string cognomeUtente, int eta)
    {
        Console.WriteLine($"Buongiorno {nomeUtente} {cognomeUtente}, hai {eta} anni, giusto?");
    }
    /*
    2. Crea un metodo VerificaPari che riceve un numero intero e stampa a video se questo numero è pari o dispari.
    */
    private static void VerificaPari(int n)
    {
        if(n % 2 == 0)
        {
            Console.WriteLine($"Il numero {n} e' Pari!");
        }
        else
        {
            Console.WriteLine($"Il numero {n} e' Dispari!");
        }
    }
    /*
    3. Scrivi un metodo CalcolaPotenza che riceve due parametri interi (baseNum ed esponente) 
    e restituisce il risultato della potenza (baseNum^esponente). Stampa a video il risultato.
    */
    private static int CalcolaPotenza(int baseNum, int esponente)
    {
        risultato_potenza = baseNum;  //posso vedere "risultato_potenza" perchè è globale
        if(esponente == 0)
        {
            return 1;
        }



        for(int i = 1; i < esponente; i++)
        {
            risultato_potenza *= baseNum;
        }
        
        return risultato_potenza;
    }



    public static void Main()
    {
        /*
            Queste variabili sono interne allo scope del metodo Main e possono essere viste,usate e modificate solo qui nel Main...
        */
        int numero_base = 0;
        int esponente = 0;
        string nome_utente = "";
        string cognome_utente = "";
        int eta_utente = 0;


        //TEST 1.
        Console.Write("Nome: ");
        nome_utente = Console.ReadLine();
        Console.Write("Cognome: ");
        cognome_utente = Console.ReadLine();
        Console.Write("Eta': ");
        eta_utente = int.Parse(Console.ReadLine());
        StampaSaluto(nome_utente, cognome_utente, eta_utente);

        //TEST 2.
        Console.Write("Numero da varificare (Pari o Dispari): ");
        numero_base = int.Parse(Console.ReadLine());
        VerificaPari(numero_base);

        //TEST 3.
        Console.Write("Inserisci la base: ");
        numero_base = int.Parse(Console.ReadLine());
        Console.Write("Inserisci l'esponente: ");
        esponente = int.Parse(Console.ReadLine());

        Console.WriteLine($"Base: {numero_base} , Esponente: {esponente} = {CalcolaPotenza(numero_base, esponente)}");


        Console.WriteLine($"Posso vedere la variabile risultato_potenza anche qui! {risultato_potenza}"); 
         //...invece posso vedere "risultato_potenza" perchè è globale
    }
}