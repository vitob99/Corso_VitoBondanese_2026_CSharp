class ModuloMarketing : IObserver
{
    public void NotificaCreazione(string nomeUtente)
    {
        Console.WriteLine($"Notifica marketing inviata all'utente '{nomeUtente}'\n");  
    }
}