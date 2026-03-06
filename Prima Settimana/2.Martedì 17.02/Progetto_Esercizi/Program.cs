using System;


class Program{
    public static void Main(string[] args){
        //1.Somma di Due Numeri 
        int a;
        int b;

        a = 10;
        b = 5;
        Console.WriteLine($"Somma: {a + b}");

        //2.Calcolo di un Prezzo Scontato
        double prezzo = 250.99d;
        Console.WriteLine($"Prezzo scontato: {prezzo*0.8}");

        //3.Controllo di un Numero Positivo
        float c = -5.5f;
        Console.WriteLine($"Positivo: {c < 0}");

        //4.Somma tra Intero e Float
        Console.Write("Inserisci un numero intero: ");
        string stringa_intero = Console.ReadLine();

        Console.Write("Inserisci un numero con la virgola: ");
        string stringa_float = Console.ReadLine();        

        int numero_intero = int.Parse(stringa_intero);
        float numero_float = float.Parse(stringa_float);
        Console.WriteLine($"Somma: {numero_intero + numero_float}");

        //5.Età e Altezza con Casting
        Console.Write("Eta': ");
        int etaUtente = int.Parse(Console.ReadLine());
        Console.Write("Altezza in metri: ");
        float altezzaUtente = float.Parse(Console.ReadLine());

        float somma = etaUtente + altezzaUtente;
        Console.WriteLine("Somma: " + (int)somma);

        //6.Extra
        Console.Write("Inserisci un intero (a) : ");
        int new_int = int.Parse(Console.ReadLine());
        Console.Write("Inserisci un altro intero intero (b) : ");
        int new_int2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"a = b e b = 5: {a == b && b == 5} , a = b o b = 5: {a == b || b == 5} , a non e'uguale b: {!(a == b)}");

        
             
    }
}
