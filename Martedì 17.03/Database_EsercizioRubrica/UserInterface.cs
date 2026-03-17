public static class UserInterface
{
    public static int MenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci un nuovo contatto");
        Console.WriteLine("[2] Visualizza tutti i contatti");
        Console.WriteLine("[3] Elimina un contatto per nome");
        Console.WriteLine("[4] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    public static void SetContatto(ref string nome_contatto, ref string telefono_contatto)
    {
        do
        {
            Console.Clear();
            Console.Write("Nome contatto: ");
            nome_contatto = Console.ReadLine()!;
        }while(nome_contatto == "");
        
        do
        {
            Console.Write("Telefono contatto: ");
            telefono_contatto = Console.ReadLine()!;
        }while(telefono_contatto == "");
    }

    public static string SetContatto()
    {
        string nome_contatto;
        do
        {
            Console.Clear();
            Console.Write("Nome contatto: ");
            nome_contatto = Console.ReadLine()!;
        }while(nome_contatto == "");
        return nome_contatto;
    }
}