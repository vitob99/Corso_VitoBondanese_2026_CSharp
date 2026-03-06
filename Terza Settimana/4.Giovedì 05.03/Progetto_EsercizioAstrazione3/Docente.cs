class Docente
{
    private string nome;
    private string materia;

    public string Nome
    {
        get{return nome;}
        set{nome = value;}
    }
    public string Materia
    {
        get{return materia;}
        set{materia = value;}
    }

    public Docente(string nome, string materia)
    {
        this.nome = nome;
        this.materia = materia;
    }

    public override string ToString()
    {
        return $"Nome docente: {nome}\nMateria: {materia}";
    }
}