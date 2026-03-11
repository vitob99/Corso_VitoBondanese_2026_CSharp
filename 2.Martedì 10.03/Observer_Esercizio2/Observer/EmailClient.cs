class EmailClient : INewsSubscriber
{
    public void AggiornaNotifica(string news)
    {
        Console.WriteLine($"Email sent: {news}");
    }
}