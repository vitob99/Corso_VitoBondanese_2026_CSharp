class ConsoleLogger : ILogger
{
    public void Log(string mex)
    {
        Console.WriteLine($"[LOG] - {mex}");
    }
}