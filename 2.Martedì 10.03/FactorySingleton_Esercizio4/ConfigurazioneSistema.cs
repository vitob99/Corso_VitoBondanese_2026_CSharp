sealed class ConfigurazioneSistema
{
    private Dictionary<string, string>? config;
    private static ConfigurazioneSistema? _instance;

    private ConfigurazioneSistema()
    {
        config = new Dictionary<string, string>();
    }
    
    public static ConfigurazioneSistema Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = new ConfigurazioneSistema();
            }
            return _instance;
        }
    }

    public void Imposta(string chiave, string valore)
    {
        config!.Add(chiave, valore);
    }
    public string Leggi(string chiave)
    {
        if (config!.ContainsKey(chiave))
        {
            return config[chiave];
        }
        throw new Exception($"Valore inesistente per la chiave {chiave}");
    }

    public int ConfigCount()
    {
        return config!.Count();
    }
    public void StampaTutte()
    {
        if(config!.Count > 0)
        {
            foreach(var c in config!)
            {
                Console.WriteLine(c);
            }              
        }
        else
        {
            Console.WriteLine("Non ci sono configurazioni registrate!");
        }

    }


}