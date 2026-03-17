using System;

class Program
{
    public static void Main(string[] args)
    {
        Cane mioCane = new Cane(); // Creazione di un oggetto della classe derivata
        mioCane.FaiVerso(); // Metodo ereditato dalla classe base
        mioCane.Scodinzola(); // Metodo definito nella classe derivata

    }
}