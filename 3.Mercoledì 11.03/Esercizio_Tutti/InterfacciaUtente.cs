class InterfacciaUtente
{
    public static string MenuSceltaPiattiBase()
    {
        string scelta_piatto_base;
        do
        {
            Console.Clear();
            Console.WriteLine("[hamburger] - Hamburger");
            Console.WriteLine("[insalata] - Insalata");
            Console.WriteLine("[pizza] - Pizza");
            Console.WriteLine("[esci] - Esci");
            Console.Write("Scelta: ");
            scelta_piatto_base = Console.ReadLine()!;
        }while(scelta_piatto_base.ToLower() != "hamburger" && scelta_piatto_base.ToLower() != "pizza" && scelta_piatto_base.ToLower() != "insalata" && scelta_piatto_base.ToLower() != "esci");
        return scelta_piatto_base;
    }

    public static string MenuSceltaExtra(IPiatto piatto)
    {
        string scelta_exta;
        do{
            Console.Clear();
            Console.WriteLine("AGGIUNTE\n");
            Console.WriteLine($"Piatto base: '{piatto!.Descrizione()}'");
            Console.WriteLine("[salsa] - Salsa");
            Console.WriteLine("[formaggio] - Formaggio");
            Console.WriteLine("[bacon] - Bacon");
            Console.WriteLine("[avanti] - Avanti");
            Console.Write("Scelta: ");
            scelta_exta = Console.ReadLine()!;
        }while(scelta_exta.ToLower() != "salsa" && scelta_exta.ToLower() != "formaggio" && scelta_exta.ToLower() != "bacon" && scelta_exta.ToLower() != "avanti");
        return scelta_exta;
    }

    public static string MenuSceltaCottura(IPiatto piatto)
    {
        string scelta_exta;
        do{
            Console.Clear();
            Console.WriteLine("COTTURA\n");
            Console.WriteLine($"Piatto base(+ aggiunte): '{piatto!.Descrizione()}'");
            Console.WriteLine("[forno] - Al forno");
            Console.WriteLine("[griglia] - Sulla griglia");
            Console.WriteLine("[fritto] - Fritto");
            Console.Write("Scelta: ");
            scelta_exta = Console.ReadLine()!;
        }while(scelta_exta.ToLower() != "forno" && scelta_exta.ToLower() != "griglia" && scelta_exta.ToLower() != "fritto");
        return scelta_exta;
    }
}