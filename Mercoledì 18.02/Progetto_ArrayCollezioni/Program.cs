using System;

class Program{
    public static void Main(string[] args)
    {
        //ARRAY
        // Creiamo un array di 5 elementi per contenere i voti
        int[] voti = new int[5];

        // Inserimento dei voti da tastiera
        for (int i = 0; i < voti.Length; i++)
        {
            Console.Write($"Inserisci il voto {i + 1}: ");
            voti[i] = int.Parse(Console.ReadLine());
        }

        // Calcolo della media
        int somma = 0;
        for (int i = 0; i < voti.Length; i++)
        {
            somma += voti[i];
        }

        float media = (float)somma / voti.Length;
        Console.WriteLine($"La media dei voti è: {media}");



        //FOR EACH
        string parola = "CSharp";
        Console.WriteLine("Caratteri della stringa:");
        foreach (char carattere in parola)
        {
            Console.WriteLine(carattere);
        }
        
        int[] array_interi = new int[5];
        array_interi[0] = 8;
        array_interi[1] = 22;
        array_interi[2] = 9;
        array_interi[3] = 2;
        array_interi[4] = 5;

        foreach(int elemento in array_interi)
        {
            Console.WriteLine(elemento);
        }

        //ESERCIZIO FOR EACH + ARRAY
        bool ripeti = true;
        do
        {
            Console.WriteLine("Che tipo di array vuoi creare?");
            Console.WriteLine("1.Stringhe");
            Console.WriteLine("2.Interi");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    Console.Write("Lunghezza dell'array di Stringhe: ");
                    int lunghezza_array_stringhe = int.Parse(Console.ReadLine());
                    string[] array_stringhe = new string[lunghezza_array_stringhe];
                    for(int i = 0; i < lunghezza_array_stringhe; i++)
                    {
                        Console.Write($"Inserisci l'elemento Stringa in posizione {i}: ");
                        array_stringhe[i] = Console.ReadLine();  
                    }
                    Console.WriteLine("Lista elementi: ");
                    foreach(string s in array_stringhe){
                        Console.WriteLine(s);
                    }

                    int scelta_array;
                    do{
                        Console.WriteLine("Vuoi creare un nuovo array?: ");
                        Console.WriteLine("1. SI");
                        Console.WriteLine("2. NO");
                        Console.Write("Scelta: ");
                        scelta_array = int.Parse(Console.ReadLine());

                        switch (scelta_array)
                        {
                            case 1:
                                break;
                            case 2:
                                ripeti = false;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                        }
                    }while(scelta_array != 1 && scelta_array != 2);
                    break;
                case 2:
                    Console.Write("Lunghezza dell'array di Interi: ");
                    int lunghezza_array_interi = int.Parse(Console.ReadLine());
                    int[] array_int = new int[lunghezza_array_interi];
                    for(int i = 0; i < lunghezza_array_interi; i++)
                    {
                        Console.Write($"Inserisci l'elemento Intero in posizione {i}: ");
                        array_int[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Lista elementi: ");
                    foreach(int intero in array_int){
                        Console.WriteLine(intero);
                    }

                    int scelta_array2;
                    do{
                        Console.WriteLine("Vuoi creare un nuovo array?: ");
                        Console.WriteLine("1. SI");
                        Console.WriteLine("2. NO");
                        Console.Write("Scelta: ");
                        scelta_array2 = int.Parse(Console.ReadLine());

                        switch (scelta_array2)
                        {
                            case 1:
                                break;
                            case 2:
                                ripeti = false;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida");
                                break;
                        }
                    }while(scelta_array2 != 1 && scelta_array2 != 2);
                        break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }while(ripeti == true);

        string prova = "PrOvA";
        Console.WriteLine(prova.ToLower());
        Console.WriteLine(prova.ToUpper());
        Console.WriteLine(prova.Length);
        Console.WriteLine(prova.Contains("Pr"));

        /*
        1. Scrivi un programma che chiede all’utente di inserire una frase e utilizza un foreach per contare quanti caratteri sono cifre (0-9).
        */
        bool esci = false;
        int n_cifre = 0;
        do
        {
            Console.WriteLine("1.Inserisci una frase");
            Console.WriteLine("2.Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    string frase;
                    int scelta_frase;
                    bool ripeti_frase = true;
                    while(ripeti_frase == true){
                        Console.Write("Frase: ");
                        frase = Console.ReadLine();
                        foreach(char c in frase)
                        {
                            if (Char.IsDigit(c))
                            {
                                n_cifre++;
                            }
                        }
                        Console.WriteLine($"La frase {frase} contiene {n_cifre} numeri!");
                        Console.WriteLine("Vuoi inserire un altra frase?: ");
                        Console.WriteLine("1. SI");
                        Console.WriteLine("2. NO");
                        Console.Write("Scelta: ");
                        scelta_frase = int.Parse(Console.ReadLine());
                        switch (scelta_frase)
                        {
                            case 1:
                                break;
                            case 2:
                                ripeti_frase = false;
                                esci = true;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida!");
                                break;
                        }
                    }
                    break;
                case 2:
                    esci = false;
                    break;
            }
        }while(esci == false );

        /*
        2. Scrivi un programma che riceve una frase dall’utente e, usando un foreach,
        costruisce e stampa una nuova stringa che contiene solo i caratteri senza spazi.
        */
        bool ripeti2 = true;
        string frase2;
        int scelta_frase2;
        while(ripeti2 == true)
        {
            Console.Write("Frase: ");
            frase2 = Console.ReadLine();
            frase2 = frase2.Replace(" ", "");
            
            Console.WriteLine($"La nuova frase è '{frase2}'");
            Console.WriteLine("Vuoi inserire un altra frase?: ");
            Console.WriteLine("1. SI");
            Console.WriteLine("2. NO");
            Console.Write("Scelta: ");
            scelta_frase2 = int.Parse(Console.ReadLine());
            switch (scelta_frase2)
            {
                case 1:
                    break;
                case 2:
                    ripeti2 = false;;
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }

        /*
        3. Scrivi un metodo che riceve una stringa e restituisce il numero di vocali contenute.
        Suggerimenti utili:
            - Usa char.ToLower() per uniformare i caratteri;
            - Usa char e Contains() su una stringa di confronto ("aeiou").
        */

        int n_vocali = 0;
        const string VOCALI = "aeiou";
        Console.Write("Stringa: ");
        string frase_vocali = Console.ReadLine();
        foreach(char c in frase_vocali)
        {
            Char.ToLower(c);
            if (VOCALI.Contains(c))
            {
                n_vocali++;
            }
        }
        Console.WriteLine($"La frase {frase_vocali} contiene {n_vocali} vocali!");

        /*
        4. Scrivi un metodo che verifica se una password è valida secondo queste regole:
            a.Deve contenere almeno una lettera maiuscola;
            b.Deve contenere almeno una cifra;
            c.Deve avere almeno 8 caratteri;
            d.Non deve iniziare o finire con uno spazio;
            e.Suggerimenti utili:
                i.Usa char.IsUpper(), char.IsDigit(), string.Length, string.StartsWith(), string.EndsWith(), string.Trim().
        */
        const int LUNGHEZZA_MINIMA = 8;
        bool lettera_maiuscola = false;
        bool almeno_una_cifra = false;
        bool lunghezza_minima = false;
        bool spazi_iniziali_finali = false;

        Console.Write("Password: ");
        string password = Console.ReadLine();
        foreach(char c in password)
        {
            if (Char.IsUpper(c))
            {
                lettera_maiuscola = true;
            }

            if (Char.IsDigit(c))
            {
                almeno_una_cifra = true;
            }
        }

        if(password.Length >= LUNGHEZZA_MINIMA)
        {
            lunghezza_minima = true;
        }
        if(!password.StartsWith(' ') && !password.EndsWith(' '))
        {
            spazi_iniziali_finali = true;
        }
        
        if(lettera_maiuscola && almeno_una_cifra && lunghezza_minima && spazi_iniziali_finali)
        {
            Console.WriteLine($"La password {password} e' valida!");
        }
        else
        {
            Console.WriteLine($"La password {password} non e' valida!");
        }
        
        /*
        5. Scrivi un metodo che riceve una stringa e restituisce:
            a.Numero di parole;
            b.Numero di caratteri alfabetici;
            c.Numero di spazi;
            d.Numero di segni di punteggiatura;
            e.Suggerimenti utili:
                i.Usa char.IsLetter(), char.IsWhiteSpace(), char.IsPunctuation();
                ii.Per contare le parole, usa string.Split(' ') ed escludi elementi vuoti.
        */

        Console.Write("Stringa: ");
        string stringa = Console.ReadLine();
        int n_parole = stringa.Split(" ").Length;

        int n_caratteri = 0;
        int n_spazi_bianchi = 0;
        int n_punteggiatura = 0;
        foreach(char c in stringa)
        {
            if (Char.IsLetter(c))
            {
                n_caratteri++;
            }
            else if(Char.IsWhiteSpace(c)){
                n_spazi_bianchi++;
            }
            else if (Char.IsPunctuation(c))
            {
                n_punteggiatura++;
            }
        }
        
        Console.WriteLine($"Numero parole = {n_parole}");
        Console.WriteLine($"Numero caratteri alfabetici = {n_caratteri}");
        Console.WriteLine($"Numero spazi bianchi = {n_spazi_bianchi}");
        Console.WriteLine($"Numero segni di punteggiatura = {n_punteggiatura}");

    }
}