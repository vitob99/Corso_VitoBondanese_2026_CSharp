class Program
{
    public static void Main(string[] args)
    {
        Printer p = new Printer();
        p.logger = new ConsoleLogger();
        p.Print("Stamopa log!");
    }
}