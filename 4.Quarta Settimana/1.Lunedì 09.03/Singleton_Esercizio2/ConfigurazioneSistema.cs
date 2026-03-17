class ConfigurazioneSistema
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
        return config![chiave];
    }

    public void StampaTutte()
    {
        foreach(var c in config!)
        {
            Console.WriteLine(c);
        }
    }


}