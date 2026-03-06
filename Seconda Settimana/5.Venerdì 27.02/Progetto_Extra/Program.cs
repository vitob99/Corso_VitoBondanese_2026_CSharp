using System;

class Program{
    //DELEGATO
    delegate void Saluto(string nome);
    public static void Main(string[] args)
    {
        //OPERATORE TERNARIO
        int n = 0;
        string stringa = n == 0 ? "Ciao" : "Come Va"; // Condizione ? true : false

        //ERROR HANDLING
        string input = "abc";
        if (int.TryParse(input, out int numero)) //PROVA LA CONVERSIONE E RESTITUISCE UN BOOLEANO
        {
        Console.WriteLine($"Numero valido: {numero}");
        }
        else
        {
            Console.WriteLine("Conversione fallita");
        }

        //TRY-CATCH-FINALLY
        int a = 10;
        int b = 0;
        try
        {
            int c = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Divisione per zero non consentita!");
            
        }
        finally
        {
            if(b == 0)
            {
                Console.WriteLine("Il divisore è uguale a zero. \n" + "la divisione non è andata a buon fine");
            }
        }

        //throw new DivideByZeroException(); lancia una eccezione




        //=========================================================================

    
       

        // Metodo compatibile
        void Ciao(string nome)
        {
            Console.WriteLine($"Ciao, {nome}!");
        }

        // Uso del delegato
        Saluto s = Ciao; //NEI DELEGATI CI POSSO METTERE I METODI
        s("Luca");

        //delegato come parametro
        void EseguiSaluto(string nome, Saluto saluto)
        {
            saluto(nome);
        }

        EseguiSaluto("Anna", Ciao);
    }
}