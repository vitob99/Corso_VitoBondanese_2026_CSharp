using System;
using System.ComponentModel.DataAnnotations;

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

    //OVERLOADING METODI
    private static void Stampa(int numero)
    {
        Console.WriteLine("Numero: " + numero);
    }
    private static void Stampa(string messaggio)
    {
        Console.WriteLine("Messaggio: " + messaggio);
    }
    private static void Stampa(int numero, string messaggio)
    {
        Console.WriteLine($"{messaggio}: {numero}");
    } 





    //PASSAGGIO PER RIFERIMENTO
    /*
    1. Scrivi un metodo Raddoppia che riceve un numero intero per ref e lo raddoppia. Mostra il valore prima e dopo.
    */
    private static void Raddoppia(ref int numero)
    {
        numero *= 2;
    }
    /*
    2. Scrivi un metodo AggiustaData che riceve tre variabili giorno, mese, anno tramite ref. 
    Se il giorno supera 30, aumenta il mese. Se il mese supera 12, aumenta l’anno.
    */
    private static void AggiustaData(ref int giorno, ref int mese, ref int anno)
    {
        if(giorno > 30)
        {
            giorno = 1;
            mese++;
        }

        if(mese > 12)
        {
            mese = 1;
            anno++;
        }   
    }
    /*
    /*
    3. Scrivi un metodo Dividi che accetta due numeri interi e restituisce il quoziente e il resto tramite out.
    */
    private static void Dividi(int n1, int n2, out double quoziente, out double resto)
    {
        quoziente = n1/n2;
        resto = n1 % n2;
    }
    /*
    4. Scrivi un metodo AnalizzaParola che riceve una stringa e restituisce tramite out:
        a.Numero di vocali;
        b.Numero di consonanti;
        c.Numero di spazi.
    */
    private static void AnalizzaParola(string s, out int n_vocali, out int n_consonanti, out int n_spazi)
    {
        n_vocali = 0;
        n_consonanti = 0;
        n_spazi = 0;

        foreach(char c in s)
        {
            if (char.IsWhiteSpace(c))
            {
                //CHECK SE E' UNO SPAZIO
                n_spazi++;    
            }
            else if (!char.IsDigit(c) && !char.IsPunctuation(c))
            {
                //SE NON E' UN NUMERO CONTROLLO SE E' UNA VOCALE
                if( char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u')
                {
                    //CHECK SE E' UNA VOCALE
                    n_vocali++;
                }
                else
                {
                    //ALTRIMENTI E' UNA CONSONANTE
                    n_consonanti++;
                }
            }          
        }


    }
    /*
    5. Scrivi un metodo AggiornaPunteggio che:
        Riceve il punteggio corrente per ref
        Riceve un bonus per valore il punteggio totale per ref, calcolato ogni volta
        Restituisce tramite out: il punteggio medio sui 3 turni
        Nota: il metodo deve essere chiamato 3 volte in sequenza, ciascuna volta inserendo un punteggio diverso. 
        Alla terza chiamata, l’out deve contenere la media.
    */
    private static void AggiornaPunteggio(ref int punteggio_attuale, int bonus, ref int punteggio_totale)
    {
        punteggio_totale += punteggio_attuale;
        if(bonus == 3)
        {
            punteggio_totale /=  bonus;
        }
    }
    /*
    6. Scrivi un metodo ElaboraStudente che: 
        a.Riceve:
            i.voto1 e voto2 (per ref)
            ii.Applicare un bonus, passato per valore, ad ogni voto (senza superare il massimo di 10).
        b.Restituire tramite out:
            i.la media dei due voti (double)
        c.ritornare (return) un valore booleano promosso, che vale true se la media è ≥ 6, false altrimenti.
        d.Nel main deve controllare se uno studente è passato o meno.    
    */
    private static bool EleboraStudente(ref int voto1, ref int voto2, int bonus, out double media_voti)
    {
        voto1 += bonus;
        voto2 += bonus;
        media_voti = (voto1 + voto2) / 2;

        if(media_voti >= 6)
        {
            return true; //PASSATO
        }
        else
        {
            return false; //NON PASSATO
        }
        
    }
    /*
    7. Scrivi un metodo AnalizzaSerieDiNumeri che:
    Prende come parametro 3 numeri (valore). come out il minimo e il massimo. come return la media dei numeri.
    */
    private static double AnalizzaSerieDiNumeri(int n1, int n2, int n3, out int massimo)
    {
        int[] serie_numeri = new int[3];
        serie_numeri[0] = n1;
        serie_numeri[1] = n2;
        serie_numeri[2] = n3;
        massimo = 0;
        foreach(int n in serie_numeri)
        {
            if(n > massimo)
            {
                massimo = n;
            }
        }
        return (n1 + n2 + n3) / 3;
    }
    /*
    8. Scrivi un metodo AggiornaVoti che:
        Valida/normalizza il voto (0–30) 
            Se votoInserito < 0 ⇒ return false, non aggiornare nulla.
            Se votoInserito > 30, riducilo con un while dividendo per 10 finché rientra in 0–30 (es.: 97 → 9).
            Applica un piccolo “bonus di impegno”:
                Usa un for, per ogni decina completa del voto (es. 23 ⇒ due iterazioni), aumenta il voto di +1 ma non oltre 30.


            Aggiorna le statistiche tramite ref count, somma, minimo, massimo, media.

    Ritorna true se tutto è andato bene.
    */
    private static bool AggiornaVoti(int votoInserito, ref int count, ref int somma, ref int minimo, ref int massimo, ref double media)
    {
        if (votoInserito < 0)
        {
            return false;
        }
        else if(votoInserito > 30)
        {
            int conto_decine = 0;
            while(votoInserito > 30)
            {
                votoInserito /= 10;
                conto_decine++;
            }

            //BONUS IMPEGNO
            for(int i = 0; i < conto_decine; i++)
            {
                if( (votoInserito + 1) <= 30)
                {
                    votoInserito++;
                }
            }

            count++;
            somma += votoInserito;
            if(votoInserito < minimo){
                minimo = votoInserito;
            }
            if(votoInserito > massimo)
            {
                massimo = votoInserito;
            }
            media = somma / count;
            
        }
        return true;
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


        //OVERLOAD METODI
        Stampa(2);
        Stampa("Ciao a tutti!");
        Stampa(2, "Ciao a tutti!");

        //ESERCIZI PASSAGGIO PER RIFEIRMENTO

        //TEST 1
        Console.WriteLine("TEST 1 ======================================");
        int n = 5;
        Console.WriteLine($"Prima: {n}");
        Raddoppia(ref n);
        Console.WriteLine($"Dopo: {n}");
        //TEST 2
        Console.WriteLine("TEST 2 ======================================");
        int n_giorno = 50;
        int n_mese = 8;
        int n_anno = 2020;
        AggiustaData(ref n_giorno, ref n_mese, ref n_anno);
        Console.WriteLine($"Nuovo giorno: {n_giorno}");
        Console.WriteLine($"Nuovo mese: {n_mese}");
        Console.WriteLine($"Nuovo anno: {n_anno}");
        //TEST 3
        Console.WriteLine("TEST 3 ======================================");
        int numero1 = 5;
        int numero2 = 3;
        double quoziente = 0;
        double resto = 0;
        Dividi(numero1, numero2, out quoziente, out resto);
        Console.WriteLine($"Quoziente: {quoziente}");
        Console.WriteLine($"Resto: {resto}");
        //TEST 4
        Console.WriteLine("TEST 4 ======================================");
        string stringa_test = "Ciao Mondo!";
        int vocali = 0;
        int consonanti = 0;
        int spazi = 0;
        AnalizzaParola(stringa_test, out vocali, out consonanti, out spazi);
        Console.WriteLine($"Vocali: {vocali}");
        Console.WriteLine($"Consonanti: {consonanti}");
        Console.WriteLine($"Spazi: {spazi}");
        //TEST 5
        Console.WriteLine("TEST 5 ======================================");
        int bonus = 0;
        int media = 0;

        int punteggio = 34;
        bonus++;
        AggiornaPunteggio(ref punteggio, bonus, ref media);
        punteggio = 56;
        
        bonus++;
        AggiornaPunteggio(ref punteggio, bonus, ref media);;
        punteggio = 22;
       
        bonus++;
        AggiornaPunteggio(ref punteggio, bonus, ref media);
        Console.WriteLine($"Media Punteggio: {media}");
        //TEST 6
        Console.WriteLine("TEST 6 ======================================");
        int voto1_studente = 5;
        int voto2_studente = 4;
        int bonus_voto = 1;
        double media_voto = 0;
        

        if ( (voto1_studente + bonus) <= 10 && (voto2_studente + bonus <= 10) )
        {
            bool esito = EleboraStudente(ref voto1_studente, ref voto2_studente, bonus_voto, out media_voto);
            Console.WriteLine($"Lo studente ha ottenuto una media di {media_voto}, Promosso = {esito}"); 
        }
        else
        {
            Console.WriteLine("Errore: controlla il bonus e i voti inseriti!");
        }

        //TEST 7
        Console.WriteLine("TEST 7 ======================================");
        int num1 = 4;
        int num2 = 6;
        int num3 = 2;
        double media_num;
        int max = 0;
        media_num = AnalizzaSerieDiNumeri(num1, num2, num3, out max);
        Console.WriteLine($"La media di {num1}, {num2}, {num3} e' {media_num}");
        Console.WriteLine($"Il massimo e' {max}");

        //TEST 8
        Console.WriteLine("TEST 8 ======================================");
        int count8 = 0;
        int somma8 = 0;
        int minimo8 = 0; 
        int massimo8 = 0;
        double media8 = 0;

        int voto8 = 45;
        AggiornaVoti(voto8, ref count8, ref somma8, ref minimo8, ref massimo8, ref media8);
        voto8 = 40;
        AggiornaVoti(voto8, ref count8, ref somma8, ref minimo8, ref massimo8, ref media8);
        voto8 = 23;
        AggiornaVoti(voto8, ref count8, ref somma8, ref minimo8, ref massimo8, ref media8);
        

        Console.WriteLine($"Minimo: {minimo8}");
        Console.WriteLine($"Massimo: {massimo8}");
        Console.WriteLine($"Media: {media8}");

    }
}