class RaccoltaAccessi
{
    private static List<LogAccesso> lista_log = new List<LogAccesso>();

    public static void Aggiungi(Persona p)
    {
        if (p != null)
        {
            LogAccesso nuovoLog = new LogAccesso(p);
            lista_log.Add(nuovoLog);
        }
    }


    public static void StampaStorico()
    {
        Console.WriteLine("ELENCO LOG");
        foreach(LogAccesso log in lista_log)
        {
            Console.WriteLine(log);
            Console.WriteLine();
        }
    }
}