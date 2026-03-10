using System;
using System.Diagnostics;

class Program
{
    public static void Main(string[] args)
    {

        //manca l'aggiunta dinamica a scelta
        Caffe c = new Caffe();

        Console.WriteLine($"Costo del caffe': {c.Costo()}$");
        Console.WriteLine($"Descrizione: {c.Descrizione()}\n");

        IBevanda decorator1 = new ConPanna(c);
        Console.WriteLine(decorator1.Descrizione());
        Console.WriteLine(decorator1.Costo() + "\n");

        IBevanda decorator2 = new ConCioccolato(decorator1);
        Console.WriteLine(decorator2.Descrizione());
        Console.WriteLine(decorator2.Costo());
    }
}