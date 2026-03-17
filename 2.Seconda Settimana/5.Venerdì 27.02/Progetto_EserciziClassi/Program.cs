using System;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        //===================================== ESERCIZIO 1
        Studente s1 = new Studente();
        s1.Nome = "Giovanni";
        s1.Matricola = 1245;
        s1.MediaVoti = 30;
        Console.WriteLine($"Nome: {s1.Nome} Matricola: {s1.Matricola} Media: {s1.MediaVoti}");

        Studente s2 = new Studente("Mario", 2345, 25);
        Console.WriteLine($"Nome: {s2.Nome} Matricola: {s2.Matricola} Media: {s2.MediaVoti}");

        //===================================== ESERCIZIO 2

        Persona p1 = new Persona();
        p1.Nome = "Antonio";
        p1.Cognome = "Neri";
        p1.AnnoNascita = 2003;
        Persona p2 = new Persona();
        p2.Nome = "Michele";
        p2.Cognome = "Bianchi";
        p2.AnnoNascita = 2000;

        p1.MostraAnnoNascita();
        p2.MostraAnnoNascita();

        //===================================== ESERCIZIO 3

        Console.Write("Inserisci il primo numero: ");
        int n1 = int.Parse(Console.ReadLine()!);
        Console.Write("Inserisci il secondo numero: ");
        int n2 = int.Parse(Console.ReadLine());

        Operazioni o = new Operazioni("Somma");
        o.risultato = o.Somma(n1, n2);
        o.StampaRisultato(o.operazione, o.risultato);

        o.operazione = "Prodotto";
        o.risultato = o.Moltiplica(n1, n2);
        o.StampaRisultato(o.operazione, o.risultato);
        

    }
}