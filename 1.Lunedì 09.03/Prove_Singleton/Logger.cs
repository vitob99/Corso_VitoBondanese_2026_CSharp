sealed class Logger
{
    private static Logger? log;

    private Logger(){}

    public static Logger GetIstanza()
    {
        if(log == null)
        {     
            log = new Logger();
            Console.WriteLine("======> CREATA ISTANZA LOGGER");
        }
        return log;
    }

    public void ScriviMessaggio(string messaggio)
    {
        Console.WriteLine($"[{DateTime.Now}] - {messaggio}");
    }
}