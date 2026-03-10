class MobileApp : INewsSubscriber
{
    public void AggiornaNotifica(string news)
    {
        Console.WriteLine($"Notification on mobile: {news}");
    }
}