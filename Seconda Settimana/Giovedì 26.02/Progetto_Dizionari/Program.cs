using System;

class Program
{
    private static int stampaMenuMagazzino()
    {
            Console.WriteLine("1. Aggiungi un nuovo prodotto");
            Console.WriteLine("2. Rimuovi un prodotto");
            Console.WriteLine("3. Cerca un prodotto");
            Console.WriteLine("4. Stampa inventario");
            Console.WriteLine("5. Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());


            return scelta;
    }
    private static int contaOccorrenze(string[] v, string s)
    {
        int count = 0;
        foreach(string st in v)
        {
           if(st == s)
            {
                count++;
            } 
        }
        return count;
    }
    public static void Main()
    {
    /*  // DICHIARAZIONE SEMPLICE
        Dictionary<int, string> studenti = new Dictionary<int, string>();

        // INIZIALIZZAZIONE CON VALORI
        Dictionary<string, string> capitali = new Dictionary<string, string>
        {
            {"Italia","Roma"},
            {"Francia","Parigi"},
            {"Spagna","Madrid"}
        };

        // AGGIUNGERE UN ELEMENTO
        studenti.Add(1,"Mario"); //da errore se presente la chiave....
        studenti[2] = "Luigi"; // alternativa con indexer, 2 non è l'indice ma la chiave!   ...se presente sostituisce

        // ACCEDERE AD UN VALORE
        Console.WriteLine(studenti[1]); // Mario

        // VERIFICARE ESISTENZA CHIAVE O VALORE
        studenti.ContainsKey(1); // true
        studenti.ContainsValue("Luigi"); // true

        // RIMUOVERE UN ELEMENTO
        studenti.Remove(2);

        // AGGIORNARE UN VALORE
        studenti[1] = "Giovanni";

        //ITERAZIONE
        foreach (var capitale in capitali)  //'var' mi accorcia la dichiarazione, 'capitale' è una coppia in 'capitali'
        {
            Console.WriteLine($"Paese: {capitale.Key}, Capitale: {capitale.Value}");
        } 
    */

        //ESERCIZI

        /*
        1. Scrivi un programma che:
            a.Crea un Dictionary<string, string> dove la chiave è il nome e il valore è il numero di telefono.
            b.Fa inserire 3 coppie nome-numero da tastiera.
            c.Stampa tutta la rubrica.
        */
        Dictionary<string, string> rubrica = new Dictionary<string, string>();
        const int MINIMO_COPPIE = 3;
        int numeri_telefono = 0;
        int i = 0;
        do
        {
            while (numeri_telefono < MINIMO_COPPIE)
            {
                Console.Write("Quante coppie vuoi inserire?: ");
                numeri_telefono = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{i + 1}° Coppia:");
            Console.Write("Nome: ");
            string nome_rubrica = Console.ReadLine();
            Console.Write("Telefono: ");
            string numero_rubrica = Console.ReadLine();
            rubrica.Add(nome_rubrica, numero_rubrica);
            i++;
        }while(i < numeri_telefono);

        Console.WriteLine();
        foreach(var n in rubrica)
        {
            Console.WriteLine($"Nome: '{n.Key}' \n Numero: {n.Value}");
        }

        /*
        2. Scrivi un programma che:
            a.Chiede all’utente di inserire una frase.
            b.Divide la frase in parole (separate da spazio).
            c.Usa un Dictionary<string, int> per contare quante volte compare ciascuna parola.
            d.Stampa ogni parola con la relativa frequenza.
        */
        Console.WriteLine();
        Console.Write("Frase: ");
        string frase = Console.ReadLine();
        string[] frase_divisa = frase.Split(' ');

        Dictionary<string, int> d_parola_freqeuenza = new Dictionary<string, int>();

       
        foreach(string p in frase_divisa)
        {
            if (!d_parola_freqeuenza.ContainsKey(p))
            {
                d_parola_freqeuenza.Add(p, contaOccorrenze(frase_divisa, p));
            } 
        }

        foreach(var coppia in d_parola_freqeuenza)
        {
             Console.WriteLine($"Parola: '{coppia.Key}' Frequenza: {coppia.Value}");
        }
        Console.WriteLine();
        Console.WriteLine("Premi un tasto per continuare");
        Console.ReadKey();
        /*
        3. Scrivi un programma che:
            a.Gestisce un Dictionary<string, int> dove la chiave è il nome di un prodotto e il valore è la quantità disponibile.
            b.Il programma deve permettere con un menu:
                i.Aggiungere un nuovo prodotto (o aumentare o diminuire la quantità se esiste già).
                ii.Rimuovere un prodotto dal magazzino.
                iii.Cercare un prodotto e mostrare la quantità.
                iv.Stampare l’inventario completo.
            c.Il menu deve ripetersi finché l’utente non sceglie “Esci”.
        */

        Dictionary<string, int> d_prodotto_quantita = new Dictionary<string, int>();
        bool esci = false;
        do
        {
            Console.Clear();
            int scelta = stampaMenuMagazzino();
            switch (scelta)
            {
                case 1: //INSERISCI NUOVO PRODOTTO / MODIFICA QUANTITA' SE ESISTE
                    Console.Write("Nuovo prodotto: ");
                    string nome_prodotto_new = Console.ReadLine();
                    if (d_prodotto_quantita.ContainsKey(nome_prodotto_new)) //controllo esistenza
                    { //se esiste modifico
                        Console.Write($"Il prodotto '{nome_prodotto_new}' esiste gia' e ha quantita' {d_prodotto_quantita[nome_prodotto_new]}, vuoi modificare la quantita' presente? (y/n): ");
                        char scelta_modifica = char.Parse(Console.ReadLine());
                        if(scelta_modifica == 'y')
                        {
                            Console.Write("Nuova quantita': ");
                            int quantita_new = int.Parse(Console.ReadLine());
                            d_prodotto_quantita[nome_prodotto_new] = quantita_new;
                            Console.WriteLine($"Quantita' modificata con successo!");
                        }
                    }
                    else
                    {  //altrimenti inserisco
                        Console.Write($"Quantita' del prodotto {nome_prodotto_new}: ");
                        int quantita_prodotto = int.Parse(Console.ReadLine());
                        d_prodotto_quantita.Add(nome_prodotto_new, quantita_prodotto);
                        Console.WriteLine($"Prodotto '{nome_prodotto_new}' aggiunto con quantita' {quantita_prodotto}"!);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey();
                    break;
                case 2:  //RIMUOVERE PRODOTTO
                    Console.Write("Cerca Prodotto da rimuovere: ");
                    string nome_prodotto_del = Console.ReadLine();
                    if (d_prodotto_quantita.Remove(nome_prodotto_del))
                    {
                        Console.WriteLine($"Il prodotto '{nome_prodotto_del}' e' stato rimosso con successo!");
                    }
                    else
                    {
                        Console.WriteLine($"Il prodotto '{nome_prodotto_del}' non e' stato trovato!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey();
                    break;
                case 3: //CERCARE PRODOTTO E DARE QUANTITA'
                    Console.Write("Cerca (Prodotto): ");
                    string nome_prodotto = Console.ReadLine();
                    if (d_prodotto_quantita.ContainsKey(nome_prodotto))
                    {
                        Console.WriteLine($"Prodotto: '{nome_prodotto}' Quantita': {d_prodotto_quantita[nome_prodotto]}");
                    }
                    else
                    {
                        Console.WriteLine($"Il prodotto '{nome_prodotto}' non e' presente!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey();
                    break;
                case 4: //INVENTARIO COMPLETO
                    int tot_inventario = d_prodotto_quantita.Count;
                    if(tot_inventario > 0)
                    {
                        Console.WriteLine($"\n Totale inventario {tot_inventario}: ");
                        foreach(var p in d_prodotto_quantita)
                        {
                            Console.WriteLine($"- Prodotto: '{p.Key}' Quantita': {p.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inventario vuoto!");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey();
                    break;
                case 5: //ESCI
                    esci = true;
                    break;
                default: //SCELTA ERRATA
                    Console.WriteLine("\n Scelta non valida!");
                    Console.WriteLine();
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey();
                    break;
            }
        }while(esci == false);


    }
}