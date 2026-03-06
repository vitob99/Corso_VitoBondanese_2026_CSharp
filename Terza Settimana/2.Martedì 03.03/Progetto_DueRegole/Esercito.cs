using Microsoft.VisualBasic;

class Esercito
{   
    public void ElencoSoldati(List<Soldato> plotone)
    {
        foreach(Soldato s in plotone)
        {
            s.Descrizione();
            Console.WriteLine();
        }
    }
}