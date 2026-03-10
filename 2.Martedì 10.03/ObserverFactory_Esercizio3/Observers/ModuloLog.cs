class ModuloLog : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"\n[{DateTime.Now}] - Notifica all'utente '{nomeUtente}'");
    }
}