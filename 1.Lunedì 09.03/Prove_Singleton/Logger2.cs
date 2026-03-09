sealed class Logger2
{
    private static Logger2? log2;

     private Logger2(){}

    public static Logger2 GetIstanza()
    {
        if(log2 == null)
        {
            log2 = new Logger2();
            Console.WriteLine("======> CREATA ISTANZA LOGGER2");
        }
        return log2;
    }

    public void GetDataOggi()
    {
        Console.WriteLine($"Data di oggi: {DateTime.Today.ToString("dd/MM/yyyy")}");
    }
}