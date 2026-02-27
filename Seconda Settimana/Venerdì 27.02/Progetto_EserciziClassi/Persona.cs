class Persona
{
    public string Nome;
    public string Cognome;
    public int AnnoNascita;


    public void MostraAnnoNascita()
    {
        Console.WriteLine($"{Nome} {Cognome} e' nato nel {AnnoNascita}!");
    }
}