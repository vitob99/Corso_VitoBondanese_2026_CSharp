using System;

class Program{
    const int MAGGIORE_ETA = 18;
    const float PREZZO_FISSO = 100;
    const float PERCENTUALE_SCONTO = 10;
    const int PASSWORD_NUMERICA_CORRETTA = 901023;
    const double PI_GRECO = 3.14159;

    public static void Main(string[] args){
        int a = 15;
        int b = 10;
        /* if (condizione == true){
            // esegui codice all'interno delle graffe
        }*/
        if(a > b){ // (a<b) da come risultato True
            Console.WriteLine($"{a} è maggiore di {b}");
            /* il blocco di codice all'interno delle graffe verrà eseguito solo
            se la condizione è vera, altrimenti verrà
            saltato e ignorato durante l’esecuzione */
        }

        /*
        1.Scrivere un programma che chieda all'utente la sua età e stampi a schermo se è maggiorenne o minorenne
            a.Richieste tecniche:
                i.Input con Console.ReadLine()
                ii.Casting implicito ed esplicito
                iii.Uso di variabili e costanti
        */
        Console.Write("Inserisci la tua eta': ");
        int etaUtente = int.Parse(Console.ReadLine());
        if(etaUtente >= MAGGIORE_ETA){
            Console.WriteLine("L'utente e' maggiorenne");
        }
        if(etaUtente < MAGGIORE_ETA){
            Console.WriteLine("L'utente e' minorenne");
        }

        /*
        2.Scrivere un programma che richiede all'utente il prezzo di un prodotto 
        e applica uno sconto del 10% se il prezzo supera 100€. 
        Stampare il prezzo finale.
                a.Richieste tecniche:
                    i.Utilizzo di input e conversioni esplicite
                    ii.Uso degli operatori aritmetici
                    iii.Stampare con formattazione della stringa
        */

        Console.Write("Prezzo del prodotto: ");
        float prezzo = float.Parse(Console.ReadLine());

        if(prezzo > PREZZO_FISSO){
            float prezzo_scontato = prezzo - prezzo * PERCENTUALE_SCONTO / 100;
            Console.WriteLine($"Prezzo scontato del 10%: {prezzo_scontato}");
        }

        /*
        3.Scrivere un programma che chiede tre numeri interi all'utente. 
        Se la media aritmetica dei tre numeri è maggiore o uguale a 60, stampare "Hai superato la prova!"
        , altrimenti stampare "Prova fallita." Stampare anche il valore esatto della media.
                a.Richieste tecniche:
                    i.Casting tra tipi (int e double)
                    ii.Utilizzo di operatori aritmetici e di confronto
                    iii.Stampa formattata di valori numerici
        */

        Console.Write("Inserisci il primo numero intero : ");
        float n1 = float.Parse(Console.ReadLine());
        Console.Write("Inserisci il secondo numero intero : ");
        float n2 = float.Parse(Console.ReadLine());
        Console.Write("Inserisci il terzo numero intero : ");
        float n3 = float.Parse(Console.ReadLine());

        float media = (n1 + n2 + n3) / 3;

        if(media >= 60){
            Console.WriteLine($"La media dei numeri inseriti è {media}: Hai superato la prova!");
        }             
        if(media < 60){
            Console.WriteLine($"La media dei numeri inseriti è {media}: Prova fallita.");
        }

        // EXTRA
        if(n1 == 5 || n2 == 10){
            Console.WriteLine("Il primo numero inserito e' uguale a 10 o il secondo e' uguale a 10");
        }
        if(n1 == 10 && n3 == 50){
            Console.WriteLine("Il primo numero inserito e' uguale a 10 e il terzo e' uguale a 50");
        }
        if(!(n1 == n2)){
            Console.WriteLine("Il primo numero inserito e il secondo sono diversi!");
        }



        //ESERCIZI IF-ELSE
        int d = 10;
        int e = 15;
        if(a > b) { // (a>b) da come risultato False
            Console.WriteLine($"{d} è maggiore di {e}");
        }
        else{
            // viene eseguito solo se la condizione nell’if è falsa
            Console.WriteLine($"{d} è minore di {e}");
        }





        /*
        1.Scrivi un programma che richiede all'utente di inserire un numero intero e determini se è pari o dispari.
                a.Richieste tecniche:
                    i.Conversione esplicita del tipo.
                    ii.Uso degli operatori aritmetici e modulo %.
        */
        
        Console.Write("Scrivi un numero: ");
        int n = int.Parse(Console.ReadLine());
        if(n % 2 == 0){
            Console.WriteLine($"Il numero {n} e' PARI");
        }
        else{
            Console.WriteLine($"Il numero {n} e' DISPARI");
        }

        /*
        2.Crea un semplice programma che richieda all’utente di inserire una password numerica. 
        Se la password inserita corrisponde a una costante predefinita, 
        stampa "Accesso consentito" , altrimenti stampa "Accesso negato"
                a.Richieste tecniche:
                    i.Uso di costanti.
                    ii.Casting e conversione esplicita.
        */

        Console.Write("Inserisci la password: ");
        int password_numerica = int.Parse(Console.ReadLine());
        if(password_numerica == PASSWORD_NUMERICA_CORRETTA){
            Console.WriteLine("Accesso consentito");
        }
        else{
             Console.WriteLine("Accesso negato");
        }

        /*
        3. Realizza una calcolatrice semplificata che chieda due numeri double e un operatore (+ oppure -). 
        Il programma dovrà effettuare l’operazione richiesta e stampare il risultato. 
        Se l’utente inserisce un operatore diverso da + o -, stampare "Operatore non valido!"
                a.Richieste tecniche:
                    i.Input multipli da tastiera.
                    ii.Casting implicito e esplicito.
                    iii.Uso combinato di operatori e stringhe.
        */
        Console.Write("Inserisci il primo numero: ");
        double operando1 = double.Parse(Console.ReadLine());
        Console.Write("Inserisci il secondo numero: ");
        double operando2 = double.Parse(Console.ReadLine());
        Console.Write("Inserisci l'operatore (+ o -)");
        char operatore = char.Parse(Console.ReadLine());

        if(operatore == '+'){
            Console.WriteLine($"La somma di {operando1} e {operando2} e' {operando1 + operando2}");
        }
        if(operatore == '-'){
            Console.WriteLine($"La differenza tra {operando1} e {operando2} e' {operando1 - operando2}");
        }
        if(operatore != '+' && operatore != '-'){
            Console.WriteLine("Operatore non valido!");
        }
        
        //ESERCIZI ELSEIF
        int voto = 28;
        if(voto >= 30){
            Console.WriteLine("Eccellente");
        }
        else if (voto >= 18){
            Console.WriteLine("Sufficiente");
        }

        int eta = 15;
        if(eta >= 18){
            Console.WriteLine("Maggiorenne");
        }
        else if (eta >= 13){
            Console.WriteLine("Adolescente");
        }
        else{
            Console.WriteLine("Bambino");
        }
    




        /*
        1.Scrivi un programma che chieda all'utente un voto da 1 a 10 e stampi una valutazione:
            a.da 1 a 4: Insufficiente
            b.da 5 a 6: Sufficiente
            c.da 7 a 8: Buono
            d.da 9 a 10: Ottimo
        */
        Console.Write("Inserisci un voto da 1 a 10: ");
        int voto_utente = int.Parse(Console.ReadLine());
        if(voto_utente >= 1 && voto_utente <= 4){
            Console.WriteLine("Insufficiente!");    
        }
        else if(voto_utente == 5 || voto_utente == 6){
            Console.WriteLine("Sufficiente");
        }

        else if(voto_utente == 7 || voto_utente == 8){
            Console.WriteLine("Buono");
        }  

        else if(voto_utente == 9 || voto_utente == 10){
            Console.WriteLine("Ottimo");
        }

        /*
        2.Scrivi un programma che calcoli il BMI (Body Mass Index).
            a.Formula BMI: peso / (altezza*altezza).
            b.Chiedi altezza (metri) e peso (kg) all'utente, poi stampa la categoria:
                i.BMI < 18.5: Sottopeso
                ii.18.5 ≤ BMI < 25: Normopeso
                iii.25 ≤ BMI < 30: Sovrappeso
                iv.BMI ≥ 30: Obesità
        */   

        Console.Write("Inserisci la tua altezza in metri: ");
        double altezza_utente = double.Parse(Console.ReadLine());
        Console.Write("Inserisci il tuo peso in kg: ");
        double peso_utente = double.Parse(Console.ReadLine());

        double bmi_utente = peso_utente / (altezza_utente * altezza_utente);
        if(bmi_utente < 18.5){
            Console.WriteLine("Sottopeso");
        }
        else if(bmi_utente >= 18.5 && bmi_utente < 25){
            Console.WriteLine("Sottopeso");
        }
        else if(bmi_utente >= 25 && bmi_utente < 30){
            Console.WriteLine("Sovrappeso");
        }
        else if(bmi_utente >= 30){
            Console.WriteLine("Obesita'");
        }

        /*
        3. Scrivi un programma che converta la temperatura inserita dall’utente da Celsius 
        verso un’altra scala scelta sempre dall’utente tra Fahrenheit, Kelvin e Rankine. 
        Stampa il risultato formattato.
        */

        Console.Write("Inserisci una temperatura in Celsius: ");
        double temperatura_celsius = double.Parse(Console.ReadLine());

        Console.Write("Scegli in quale scala convertire la temperatura (Fahrenheit, Kelvin, Rankine): ");
        string scala_conversione_scelta = Console.ReadLine();

        if(scala_conversione_scelta == "Fahrenheit"){
            double temperatura_fahrenheit = (temperatura_celsius * 0.8) + 32;
            Console.WriteLine($"{temperatura_celsius} gradi Celsius sono {temperatura_celsius} gradi Fahrenheit");
        }
        else if(scala_conversione_scelta == "Kelvin"){
            double temperatura_kelvin = temperatura_celsius + 273.15;
            Console.WriteLine($"{temperatura_celsius} gradi Celsius sono {temperatura_kelvin} gradi Kelvin");
        }
        else if(scala_conversione_scelta == "Rankine"){
            double temperatura_rankine = (temperatura_celsius * 1.8) + 491.67;
            Console.WriteLine($"{temperatura_celsius} gradi Celsius sono {temperatura_rankine} gradi Kelvin");            
        }

        //SWITCH
        string giorno = "lunedì";
        switch (giorno){
            case "lunedì":
                Console.WriteLine("Inizio settimana");
                break;
            case "venerdì":
                Console.WriteLine("Quasi weekend");
                break;
            default:
                Console.WriteLine("Altro giorno");
                break;
        }


        /*
        1. Scrivi un programma che chieda all’utente di inserire un numero da 1 a 7 
        e restituisca il giorno corrispondente della settimana.
        */
        Console.Write("Inserisci un numero da 1 a 7: ");
        int numero_giorno = int.Parse(Console.ReadLine());
        switch (numero_giorno){
            case 1:
                Console.WriteLine("Lunedi'");
                break;
            case 2:
                Console.WriteLine("Martedi'");
                break;
            case 3:
                Console.WriteLine("Mercoledi'");
                break;
            case 4:
                Console.WriteLine("Giovedi'");
                break;
            case 5: 
                Console.WriteLine("Venerdi'");
                break;
            case 6:
                Console.WriteLine("Sabato");
                break;
            case 7:
                Console.WriteLine("Domenica");
                break;
            default:
                Console.WriteLine("Giorno indefinito!");
                break;
        }

        /*
        2. Scrivi un programma che chieda all'utente quale figura geometrica vuole calcolare 
        tra quadrato, cerchio e triangolo, quindi chiede le misure necessarie e calcola l'area corrispondente.
        */
        Console.Write("Di quale forma vuoi calcolare l'area? (Quadrato, Cerchio, Triangolo): ");
        string forma = Console.ReadLine();
        switch(forma){
            case "Quadrato":
                Console.Write("Dimensione lato in cm: ");
                double lato_quadrato = double.Parse(Console.ReadLine());
                double area_quadrato = lato_quadrato * lato_quadrato;
                Console.WriteLine($"L'area del quadrato e' {area_quadrato}cm quadrati");
                break;
            case "Cerchio":
                Console.Write("Dimensione raggio in cm: ");
                double raggio_cerchio = double.Parse(Console.ReadLine());

                double area_cerchio = PI_GRECO * (raggio_cerchio * raggio_cerchio);
                Console.WriteLine($"L'area del cerchio e' {area_cerchio}cm quadrati");
                break;
            case "Triangolo":
                Console.Write("Dimensione base in cm: ");
                double base_triangolo = double.Parse(Console.ReadLine());
                Console.Write("Dimensione altezza in cm: ");
                double altezza_triangolo = double.Parse(Console.ReadLine());

                double area_triangolo = (base_triangolo * altezza_triangolo) / 2;
                Console.WriteLine($"L'area del triangolo e' {area_triangolo}cm quadrati");
                break;
            default:
                Console.WriteLine("Forma non valida");
                break;
        }
    }
}