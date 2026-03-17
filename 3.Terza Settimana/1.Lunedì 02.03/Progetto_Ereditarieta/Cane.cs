//classe derivata
class Cane : Animale
{

     // Metodo specifico della classe derivata
    public void Scodinzola()
    {
        Console.WriteLine("Il cane scodinzola.");
    }

    public new void Mangia()
    {
        Console.WriteLine("Il cane mangia i coccantini!");
    }
    public override void Verso()
    {
        base.Verso(); // Chiama il metodo Verso della classe base
        Console.WriteLine("Il cane abbaia.");
    }

    public void impostaEta(int nuova_eta)
    {
        eta = nuova_eta;
    }
}