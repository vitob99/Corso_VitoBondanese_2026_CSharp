class Utente
{
    public string nome{get; set;}
    public int credito{get; set;}

    public Utente(string nome, int credito)
    {
        this.nome = nome;
        this.credito = credito;
    }

    public Utente()
    {
        nome = "Default";
        credito = 10;
    }

    public override string ToString()
    {
        return $"Info utente:\n Nome: {nome}\n Credito: {credito}";
    }

    public override bool Equals(object? u)
    {
        if(u is Utente u2)
        {
            return nome == u2.nome && credito == u2.credito;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(nome, credito);
    }
}