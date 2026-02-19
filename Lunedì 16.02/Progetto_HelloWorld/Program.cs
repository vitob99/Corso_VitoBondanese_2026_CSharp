using System;
using System.Security.Cryptography.X509Certificates;


//classe Program

class Program{
    const float PI_NUMBER = 3.14159264359f; //costante di compilazione
    public static readonly string Nome = "Franco"; //costante di runtime
    public static void Main(string[] args){
        Console.WriteLine("Hello World!");
        /*
            Hello World!
        */

        //variabile di tipo intero 'x'
        int x = 10;
        Console.WriteLine(x);
        /*
            10
        */
        int numeroIntero = 10; //variabile intera
        float decimaleFloat = 12.3f; //variabile decimale in virgola mobile
        double decimaleDouble = 3.14d; //variabile decimale
        char carattereSingolo = 'C'; //variabile carattere
        bool condizione = true; //bit 0 = false  bit 1 = true
        string frase = "Hello World!"; //variabile stringa, sequenza di caratteri

        Console.WriteLine("Numero intero: " + numeroIntero);
        Console.WriteLine("Numero decimale Float: " + decimaleFloat);
        Console.WriteLine("Numero decimale Double: " + decimaleDouble);
        Console.WriteLine("Carattere: " + carattereSingolo);
        Console.WriteLine("Condizione: " + condizione);
        Console.WriteLine("Stringa: " + frase);

        
        Console.WriteLine(PI_NUMBER);
        Console.WriteLine("Mi chiamo " + Nome);
  
        // Implicito (safe, nessuna perdita di dati)
        int intero = 42;
        float numeroLungo = intero; // widening - da più piccolo a più grandi  
        Console.WriteLine(numeroLungo); 

        // Esplicito (potenziale perdita / eccezione)
        float pi = 3.14f;
        int circaPi = (int)pi; // narrowing - da più grande al più piccolo
        Console.WriteLine(circaPi);
     
        Console.Write("Come ti Chiami?");
        string nome = Console.ReadLine(); //aspetto un input da tastiera
        Console.WriteLine($"Ciao {nome}!");
    
        Console.Write("Dammi un numero? ");
        string n1 = Console.ReadLine(); 
        Console.Write("Dammi un altro numero? ");
        string n2 = Console.ReadLine();

        int numero1 = int.Parse(n1); //Conversione da string a int
        int numero2 = int.Parse(n2);
        Console.WriteLine($"Somma {numero1 + numero2}!");


        int a = 10;
        int b = 5;
        Console.WriteLine("Operatori aritmetici:");

        Console.WriteLine($"a = {a}, b = {b}"); //uguale
        Console.WriteLine($"Addizione: a + b = {a + b}"); //addizione
        Console.WriteLine($"Sottrazione: a - b = {a - b}"); //sottrazione
        Console.WriteLine($"Moltiplicazione: a * b = {a * b}");   //moltiplicazione
        Console.WriteLine($"Divisione: a / b = {a / b}");  //divisione
        Console.WriteLine($"Modulo (resto): a % b = {a % b}"); //mobulo

        Console.WriteLine("Operatori Assegnamento:");
        Console.WriteLine($"Incremento: a++ = {a++}"); // Stampa a, poi incrementa a di 1
        Console.WriteLine($"Ora a = {a}");
        Console.WriteLine($"Decremento: --b = {--b}"); // Stampa b, poi decrementa b di 1
        Console.WriteLine($"Ora b = {b}");

        int c = 10;
        int d = 15;
        Console.WriteLine("Operatori Logici:");
        Console.WriteLine($"AND: {c < d && c >= 10}"); // True - con && restituisce True se entrambi le condizioni sono vere, falso altrimenti
        Console.WriteLine($"OR: {c > d || c >= 10}"); // True - con || restituisce True se almeno una delle condizioni è vera, falso altrimenti
        Console.WriteLine($"NOT: {!(c < d)}"); // False - con ! nego la condizione


    }
}