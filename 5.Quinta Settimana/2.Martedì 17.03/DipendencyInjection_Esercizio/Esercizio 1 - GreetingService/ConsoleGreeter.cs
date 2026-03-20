class ConsoleGreeter : IGreeter
{
    public void Greet(string messaggio)
    {
        Console.WriteLine($"Messaggio: {messaggio}");
    }
}