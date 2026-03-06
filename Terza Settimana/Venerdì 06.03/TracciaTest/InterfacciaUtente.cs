class InterfacciaUtente
{
    private InterfacciaUtente(){}

    public static int MenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci una Pecora");
        Console.WriteLine("[2] Inserisci una Gallina");
        Console.WriteLine("[3] Inserisci una Mucca");
        Console.WriteLine("[4] Inserisci un Maiale");
        Console.WriteLine("[5] Rimuovi un animale");
        Console.WriteLine("[6] Lista animali");
        Console.WriteLine("[7] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    public static void MenuInserimentoPecora(ref string nome, ref int eta, ref double peso, ref bool tosata)
    {
        Console.Clear();
        Console.Write("Inserisci il nome della Pecora: ");
        nome = Console.ReadLine()!;
        Console.Write("Eta' Pecora: ");
        eta = int.Parse(Console.ReadLine()!);
        Console.Write("Peso Pecora: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.Write("Tosata (y / n): ");
        char risposta_tosata = char.Parse(Console.ReadLine()!);
        if(risposta_tosata == char.ToLower('y')){
            tosata = true;
        }
        else
        {
            tosata = false;
        }
    }

    public static void MenuInserimentoGallina(ref string nome, ref int eta, ref double peso, ref int numero_uova)
    {
        Console.Clear();
        Console.Write("Inserisci il nome della Gallina: ");
        nome = Console.ReadLine()!;
        Console.Write("Eta' Gallina: ");
        eta = int.Parse(Console.ReadLine()!);
        Console.Write("Peso Gallina: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.Write("Numero di uova: ");
        numero_uova = int.Parse(Console.ReadLine()!);
    }

    public static void MenuInserimentoMucca(ref string nome, ref int eta, ref double peso, ref int numero_macchie)
    {
        Console.Clear();
        Console.Write("Inserisci il nome della Mucca: ");
        nome = Console.ReadLine()!;
        Console.Write("Eta' Mucca: ");
        eta = int.Parse(Console.ReadLine()!);
        Console.Write("Peso Mucca: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.Write("Numero macchie: ");
        numero_macchie = int.Parse(Console.ReadLine()!);
    }

    public static void MenuInserimentoMaiale(ref string nome, ref int eta, ref double peso, ref bool sporco)
    {
        Console.Clear();
        Console.Write("Inserisci il nome della Maiale: ");
        nome = Console.ReadLine()!;
        Console.Write("Eta' Maiale: ");
        eta = int.Parse(Console.ReadLine()!);
        Console.Write("Peso Maiale: ");
        peso = double.Parse(Console.ReadLine()!);
        Console.Write("Sporco (y / n): ");
        char risposta_tosata = char.Parse(Console.ReadLine()!);
        if(risposta_tosata == char.ToLower('y')){
            sporco = true;
        }
        else
        {
            sporco = false;
        }
    }

    public static string MenuEliminaAnimale()
    {
        Console.Write("Nome animale da eliminare: ");
        return Console.ReadLine()!;
    }

}