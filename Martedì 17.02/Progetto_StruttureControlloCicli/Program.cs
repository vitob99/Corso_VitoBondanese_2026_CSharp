using System;

class Program{
    const int NUMERO_SEGRETO = 74;
    const int PASSWORD_CORRETTA = 9024;
    const int TENTATIVI_POSSIBILI = 3;
    public static void Main(string[] args){
        //CICLO WHILE
        bool continua = true;
        while (continua){ //finché “continua” rimane true il codice viene ripetuto
            Console.WriteLine("Ciclo in esecuzione");
            continua = bool.Parse(Console.ReadLine());
        }

        int continua2 = 0;
        while(continua2 < 10){
            Console.WriteLine("Ciclo in esecuzione");
            continua2 += 1;
        }


        /*
        1. Scrivi un programma che continui a chiedere all’utente di inserire numeri interi positivi.
           Il programma termina quando l’utente inserisce un numero negativo e stampa la
           somma totale dei numeri inseriti (senza contare il numero negativo).
        */
        int somma = 0;
        int numero = 1;
        while (numero > 0){
            Console.Write("Inserisci un numero positivo: ");
            numero = int.Parse(Console.ReadLine());
            if(numero > 0){
                somma += numero;
            }
        }
        Console.WriteLine($"La somma e' {somma}");


        /*
        2. Scrivi un programma che definisca un numero segreto come costante. L'utente dovrà
        indovinare questo numero continuando a fare tentativi finché non lo indovina
        correttamente. Il programma risponde ogni volta indicando se il numero inserito è
        maggiore o minore rispetto al numero segreto.
        */
        bool trovato = false;
        while(trovato == false){
            Console.Write("Inserisci un numero: ");
            int numero_inserito = int.Parse(Console.ReadLine());
            if(numero_inserito > NUMERO_SEGRETO){
                Console.WriteLine($"Sbagliato! Il numero {numero_inserito} e' piu' grande del numero segreto!");
            }
            else if(numero_inserito < NUMERO_SEGRETO){
                Console.WriteLine($"Sbagliato! Il numero {numero_inserito} e' piu' piccolo del numero segreto!");
            }
            else if(numero_inserito == NUMERO_SEGRETO)
            {
                Console.WriteLine($"Corretto, {numero_inserito} e' il numero segreto!");
                trovato = true;
            }
        }

        /*
        3. Scrivere un programma che simuli il funzionamento di un semplice sportello bancomat,
        utilizzando un ciclo while per gestire un menu di operazioni finché l'utente non decide di uscire.
            a.Requisiti:
                i.Il programma deve mostrare un menu con le seguenti opzioni:
                    1: Visualizza saldo
                    2: Deposita denaro
                    3: Preleva denaro
                    4: Esci
                ii.Il saldo iniziale è 0.
                iii.L'utente può ripetere le operazioni quante volte vuole, finché non sceglie l'opzione 4.
                iv.Se si tenta di prelevare più del saldo disponibile, mostrare un messaggio di errore.
        */
        bool esci = false;
        double saldo = 0d;
        while(esci == false)
        {
            Console.WriteLine("1: Visualizza saldo");
            Console.WriteLine("2: Deposita denaro");
            Console.WriteLine("3: Preleva denaro");
            Console.WriteLine("4: Esci");
            Console.Write("Scegli: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine($"Il saldo attuale e' di {saldo} euro");
                    break;
                case 2:
                    Console.Write("Quanto denaro vuoi depositare?: ");
                    double deposita_denaro = double.Parse(Console.ReadLine());
                    saldo += deposita_denaro;
                    Console.WriteLine($"Hai depositato {deposita_denaro} euro!");
                    break;
                case 3:
                    Console.Write("Quanto denaro vuoi prelevare?: ");
                    double preleva_denaro = double.Parse(Console.ReadLine());
                    if(preleva_denaro > saldo)
                    {
                        Console.WriteLine($"Impossibile prelevare {preleva_denaro} euro, il saldo attuale e' di {saldo} euro!");
                    }
                    else
                    {
                        saldo -= preleva_denaro;
                        Console.WriteLine($"Hai prelevato {preleva_denaro} euro, rimangono {saldo} euro sul conto!");
                    }
                    break;
                case 4:
                    esci = true;
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }

        //EXTRA
        bool esci2 = false;
        double saldo2 = 0d;
        while(esci2 == false)
        {
            Console.WriteLine("1: Visualizza saldo");
            Console.WriteLine("2: Deposita denaro");
            Console.WriteLine("3: Preleva denaro");
            Console.WriteLine("4: Esci");
            Console.Write("Scegli: ");
            int scelta2 = int.Parse(Console.ReadLine());

            switch (scelta2)
            {
                case 1: //CASO VISUALIZZA SALDO
                    bool esci_visualizza = false;
                    while (esci_visualizza == false)
                    {
                        Console.WriteLine("1.Visualizza saldo in euro");
                        Console.WriteLine("2.Visualizza saldo in dollari");
                        Console.WriteLine("3.Visualizza saldo in franchi");
                        Console.WriteLine("4.Torna al menu' principale");
                        Console.Write("Scelta: ");
                        int scelta_valuta = int.Parse(Console.ReadLine());

                        switch (scelta_valuta)
                        {
                            case 1:   //CASO EURO
                                Console.WriteLine($"Il saldo in euro e' {saldo2} euro!");
                                break;
                            case 2:   //CASO DOLLARO
                                Console.WriteLine($"Il saldo in dollari e' {saldo2} dollari!");
                                break;
                            case 3:   //CASO FRANCO
                                Console.WriteLine($"Il saldo in franchi e' {saldo2} franchi!");
                                break; 
                            case 4: //CASO TORNA AL MENU
                                esci_visualizza = true;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida!");
                                break;
                        }
                    }
                    break;

                case 2: //CASO DEPOSITA DENARO
                    bool esci_deposita = false;
                    while(esci_deposita == false)
                    {
                        Console.WriteLine("1.Deposita denaro in euro");
                        Console.WriteLine("2.Deposita denaro in dollaro");
                        Console.WriteLine("3.Deposita denaro in franchi");
                        Console.WriteLine("4.Torna al menu' principale");

                        Console.Write("Scelta: ");
                        int scelta_deposita = int.Parse(Console.ReadLine());

                        switch (scelta_deposita)
                        {
                            case 1: //CASO DEPOSITA EURO
                                Console.Write("Quanti euro vuoi depositare?: ");
                                double deposita_euro = double.Parse(Console.ReadLine());

                                saldo2 += deposita_euro;
                                Console.WriteLine($"Hai depositato {deposita_euro} euro!");
                                break;
                            case 2:  //CASO DEPOSITA DOLLARI
                                Console.Write("Quanti dollari vuoi depositare?: ");
                                double deposita_dollari = double.Parse(Console.ReadLine());

                                saldo2 += deposita_dollari;
                                Console.WriteLine($"Hai depositato {deposita_dollari} dollari!");
                                break;
                            case 3:  //CASO DEPOSITA FRANCHI
                                Console.Write("Quanti franchi vuoi depositare?: ");
                                double deposita_franchi = double.Parse(Console.ReadLine());

                                saldo2 += deposita_franchi;
                                Console.WriteLine($"Hai depositato {deposita_franchi} franchi!");
                                break;
                            case 4:  //CASO TORNA AL MENU
                                esci_deposita = true;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida!");
                                break;                            
                        }
                    }
                    break;

                case 3: //CASO PRELEVA DENARO
                    bool esci_preleva = false;
                    while(esci_preleva == false)
                    {
                        Console.WriteLine("1.Preleva euro");
                        Console.WriteLine("2.Preleva dollari");
                        Console.WriteLine("3.Preleva franchi");
                        Console.WriteLine("4.Torna al menu' principale");
                        Console.Write("Scelta: ");
                        int scelta_preleva = int.Parse(Console.ReadLine());

                        switch (scelta_preleva)
                        {
                            case 1:
                                Console.Write("Quanti euro vuoi prelevare?: ");
                                double preleva_euro = double.Parse(Console.ReadLine());

                                if(preleva_euro > saldo2)
                                {
                                    Console.WriteLine($"Impossibile prelevare {preleva_euro} euro, il saldo attuale e' di {saldo2} euro!");
                                }
                                else
                                {
                                    saldo2 -= preleva_euro;
                                    Console.WriteLine($"Hai prelevato {preleva_euro} euro, rimangono {saldo2} euro sul conto!");
                                }
                                break;
                            case 2:
                                Console.Write("Quanti dollari vuoi prelevare?: ");
                                double preleva_dollari = double.Parse(Console.ReadLine());                            
                                if(preleva_dollari > saldo2)
                                {
                                    Console.WriteLine($"Impossibile prelevare {preleva_dollari} euro, il saldo attuale e' di {saldo2} euro!");
                                }
                                else
                                {
                                    saldo2 -= preleva_dollari;
                                    Console.WriteLine($"Hai prelevato {preleva_dollari} euro, rimangono {saldo2} euro sul conto!");
                                }                                
                                break;
                            case 3:
                                Console.Write("Quanti franchi vuoi prelevare?: ");
                                double preleva_franchi = double.Parse(Console.ReadLine());

                                if(preleva_franchi > saldo2)
                                {
                                    Console.WriteLine($"Impossibile prelevare {preleva_franchi} euro, il saldo attuale e' di {saldo2} euro!");
                                }
                                else
                                {
                                    saldo2 -= preleva_franchi;
                                    Console.WriteLine($"Hai prelevato {preleva_franchi} euro, rimangono {saldo2} euro sul conto!");
                                }                                
                                break;
                            case 4:
                                esci_preleva = true;
                                break;
                            default:
                                Console.WriteLine("Scelta non valida!");
                                break;
                        }
                    }  
                    break;
                case 4: //CASO ESCI
                    esci2 = true;
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
        }        





        //CICLO DO-WHILE
        bool continua3 = true;
        do //prima esegue il codice poi controlla se la condizione è vera
        {
            Console.WriteLine("Ciclo in esecuzione");
            //continua = VerificaCondizione();
            continua3 = false;
        }while (continua3); //finché continua rimane true il codice viene ripetuto

        /*
        1. Scrivi un programma che chieda una password numerica all'utente. 
        Ha a disposizionefino a 3 tentativi. Il programma termina se la password è corretta o se finiscono i tentativi disponibili.
        */
        int tentativi_disponibili = TENTATIVI_POSSIBILI;
        int password_inserita;
        do
        {
            Console.Write("Inserisci una password numerica: ");
            password_inserita = int.Parse(Console.ReadLine());

            if(password_inserita != PASSWORD_CORRETTA && tentativi_disponibili > 0)
            {
                tentativi_disponibili--;
                Console.WriteLine($"Errore! Hai {tentativi_disponibili} tentativi rimanenti!");
            }
        }while(tentativi_disponibili > 0 || password_inserita == PASSWORD_CORRETTA);
        if(password_inserita == PASSWORD_CORRETTA)
        {
            Console.WriteLine("Password corretta!");
        }
        else if(tentativi_disponibili == 0)
        {
            Console.WriteLine("Hai esaurito i tentativi!");
        }
        /*
        2. Realizza un programma che permette all'utente di inserire numeri interi finché non inserisce lo zero. 
        Al termine, stampa la somma e quanti numeri sono stati inseriti.
        */
        int n_inserito;
        int n_totali = 0;
        int somma2 = 0;
        do
        {
            Console.Write("Inserisci numero intero: ");
            n_inserito = int.Parse(Console.ReadLine());
            
            if(n_inserito != 0)
            {
                somma2 += n_inserito;
                n_totali++;
            }
        }while(n_inserito != 0);

        Console.WriteLine($"Somma totale dei numeri: {somma2}");
        Console.WriteLine($"Numero totale interi inseriti: {n_totali}");

        /*
        3. Crea una calcolatrice che permette all’utente di effettuare più operazioni matematiche (+, -, *, /). 
        Dopo ogni operazione, il programma chiede se vuole eseguire un'altra operazione o terminare.
        */
        bool ripeti = true;
        do
        {
            Console.WriteLine("1.Addizione");
            Console.WriteLine("2.Sottrazione");
            Console.WriteLine("3.Moltiplicazione");
            Console.WriteLine("4.Divisione");
            Console.Write("Scelta: ");
            int scelta_operazione = int.Parse(Console.ReadLine());

            switch (scelta_operazione)
            {
                case 1:
                    Console.Write("Inserisci il primo numero: ");
                    double n1_addizione = double.Parse(Console.ReadLine());
                    Console.Write("Inserisci il Secondo numero: ");
                    double n2_addizione = double.Parse(Console.ReadLine());

                    Console.WriteLine($"La somma e': {n1_addizione + n2_addizione}");
                    break;
                case 2:
                    Console.WriteLine("Inserisci il primo numero: ");
                    double n1_sottrazione = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il Secondo numero: ");
                    double n2_sottrazione = double.Parse(Console.ReadLine());

                    Console.WriteLine($"La differenza e': {n1_sottrazione - n2_sottrazione}");
                    break;
                case 3:
                    Console.WriteLine("Inserisci il primo numero: ");
                    double n1_moltiplicazione = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il Secondo numero: ");
                    double n2_moltiplicazione = double.Parse(Console.ReadLine());

                    Console.WriteLine($"La differenza e': {n1_moltiplicazione * n2_moltiplicazione}");
                    break;
                case 4:
                    Console.WriteLine("Inserisci il primo numero: ");
                    double n1_divisione = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inserisci il Secondo numero: ");
                    double n2_divizione = double.Parse(Console.ReadLine());
                    Console.WriteLine($"La differenza e': {n1_divisione * n2_divizione}");
                    break;
                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }
                int risposta_ripeti;
                do{
                    Console.WriteLine("Vuoi eseguire una ulteriore operazione?");
                    Console.WriteLine("1. SI");
                    Console.WriteLine("2. NO");
                    Console.Write("Scelta: ");
                    risposta_ripeti = int.Parse(Console.ReadLine());
                    switch (risposta_ripeti)
                    {
                        case 1:
                            break;
                        case 2:
                            ripeti = false;
                            break;
                        default:
                            Console.WriteLine("Scelta non valida!");
                            break;                    
                    }
                }while(risposta_ripeti != 1 && risposta_ripeti != 2);
        }while(ripeti);




        //CICLO FOR
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }       

        /*
        1. Scrivi un programma che chieda all'utente un numero intero e stampi la sua tabellina (moltiplicazioni da 1 a 10).
        */
        Console.Write("Inserisci un numero intero: ");
        int n = int.Parse(Console.ReadLine());
        if(n == 0)
        {
            Console.WriteLine("Il risultato sarà sempre 0");
        }
        else
        {
            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }            
        }

        /*
        2. Scrivi un programma che chieda all'utente quanti numeri interi vuole inserire. 
        Il programma acquisisce i numeri e alla fine calcola e stampa la loro media.
        */
        Console.Write("Quanti numeri vuoi inserire?: ");
        int n_da_inserire = int.Parse(Console.ReadLine());
        int somma_numeri = 0;
        for(int i = 1; i <= n_da_inserire;i++)
        {
            Console.Write($"Inserisci il {i}° numero: ");
            somma_numeri += int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"La media dei numeri inseriti e' {somma_numeri / n_da_inserire}");
        /*
        3. Scrivi un programma che chieda all'utente un numero intero positivo e calcoli il suo fattoriale (n!). 
        Assicurati che l'utente inserisca un numero positivo; in caso contrario, mostra un messaggio di errore.
        */
        int n_inserito_fattoriale;
        int risultato_fattoriale = 1;
        do
        {
            Console.Write("Inserisci un numero positivo: ");
            n_inserito_fattoriale = int.Parse(Console.ReadLine());
            if(n_inserito_fattoriale < 0)
            {
                Console.WriteLine("L'intero inserito deve essere positivo!");
            }
        }while(n_inserito_fattoriale < 0);


        for(int i = 1; i <= n_inserito_fattoriale; i++)
        {
            risultato_fattoriale *= i;
        }
        Console.WriteLine($"Il fattoriale di {n_inserito_fattoriale} e' {risultato_fattoriale}");

        

        
    }
}