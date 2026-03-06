using System;

class Program
{
    public static void Main(string[] args)
    {
        List<Veicolo> officina = new List<Veicolo>()
        {
            new Auto("AAA2"), 
            new Moto("MMM2"),
            new Moto("MMM6"),
            new Auto("AAA3")
        };

        foreach(Veicolo v in officina) 
        {
            Console.WriteLine(v.Targa);
            v.Ripara(); //a seconda del tipo di 'v' verrà eseguito il relativo metodo 'Ripata()' corrispondente al relativo tipo figlio di 'Veicolo'
        }
    }
}