sealed class UserInterface
{
    private UserInterface(){}

    public static string MenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("BENVENUTO");
        Console.WriteLine();
        Console.Write("Inserisci il codice del tuo badge: ");
        return Console.ReadLine()!;
    }
}