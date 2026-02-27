using System;
using System.Security.Cryptography.X509Certificates;




class Program
{
    public static void Main(string[] args)
    {
        Cane c = new Cane();
        c.Abbaia();
        Console.WriteLine(c.nome);

        Persona p = new Persona("Marco", 25);
        p.Presentati();
    }
}


