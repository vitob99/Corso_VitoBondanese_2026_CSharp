class Utente
{
    private string? nome;
    
    public string Nome
    {
        get
        {
            return nome!;
        }
        set
        {
            nome = value;
        }
    }

    public Utente(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return $"Nome: {nome}";
    }
}