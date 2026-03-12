// Facade: semplifica l'utilizzo del sistema Home Theater
public class HomeTheaterFacade
{
    // Riferimenti ai vari sottosistemi
    private TV _tv;
    private AudioSystem _audioSystem;
    private Lights _lights;

    // Costruttore: riceve i componenti del sistema
    public HomeTheaterFacade(TV tv, AudioSystem audioSystem, Lights lights)
    {
        _tv = tv;
        _audioSystem = audioSystem;
        _lights = lights;
    }

    // Metodo semplificato per avviare la visione di un film
    public void WatchMovie()
    {
        Console.WriteLine("Avvio modalità cinema...");
        _lights.Dim();              // Abbassa le luci
        _tv.TurnOn();               // Accende la TV
        _audioSystem.TurnOn();      // Accende l'audio
        _audioSystem.SetVolume(20); // Imposta il volume
    }

    // Metodo semplificato per terminare la visione
    public void EndMovie()
    {
        Console.WriteLine("Chiusura modalità cinema...");
        _audioSystem.TurnOff(); // Spegne l'audio
        _tv.TurnOff();          // Spegne la TV
        _lights.Brighten();     // Riporta le luci normali
    }
}
