class Logger
{
    private List<string> log_list;
    private static Logger? log;

    private Logger()
    {
        log_list = new List<string>();
    }

    public static Logger Instance{
        get
        {
            if(log == null)
            {
                log = new Logger();
            }
            return log;
        }
    }

    public void Log(string message)
    {
        log_list.Add(message);
    }

    public void StampaLog()
    {
        Console.Clear();
        Console.WriteLine("LISTA LOG");
        foreach(string log in log_list)
        {
            Console.WriteLine($"[{DateTime.Now}] - {log}");
        }
    }
}