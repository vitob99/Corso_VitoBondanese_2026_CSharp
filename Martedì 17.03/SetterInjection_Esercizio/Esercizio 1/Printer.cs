class Printer
{
    public ILogger logger;

    public void Print(string mex)
    {
        if (logger != null)
        {
            logger.Log(mex);
        }
        else
        {
            Console.WriteLine("Errore: inietta una dipendenza ILogger");
        }
        
    }
}