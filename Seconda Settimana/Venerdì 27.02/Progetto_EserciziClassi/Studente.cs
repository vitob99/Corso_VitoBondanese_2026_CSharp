class Studente
{
    public string Nome;
    public int Matricola;
    public int MediaVoti;

    public Studente()
    {
        Nome = "Nome Default";
        Matricola = 0;
        MediaVoti = 0;
    }

    public Studente(string Nome, int Matricola, int MediaVoti)
    {
        this.Nome = Nome;
        this.Matricola = Matricola;
        this.MediaVoti = MediaVoti;
    }
}