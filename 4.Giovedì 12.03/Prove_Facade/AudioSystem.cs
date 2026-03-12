// Sottosistema 2: gestione dell'audio
public class AudioSystem
{
    // Accende l'impianto audio
    public void TurnOn()
    {
        Console.WriteLine("Sistema audio acceso.");
    }

    // Imposta il volume
    public void SetVolume(int level)
    {
        Console.WriteLine("Volume impostato a " + level + ".");
    }

    // Spegne l'impianto audio
    public void TurnOff()
    {
        Console.WriteLine("Sistema audio spento.");
    }
}