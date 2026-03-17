class Libro{
    private string titolo;
    private string autore;
    private int anno_pubblicazione;

    public Libro()
    {
        titolo = "Titolo Default";
        autore = "Autore Default";
        anno_pubblicazione = 0;
    }
    public Libro(string titolo, string autore, int anno_pubblicazione)
    {
        this.titolo = titolo;
        this.autore = autore;
        this.anno_pubblicazione = anno_pubblicazione;
    }

    ~Libro()
    {
        Console.WriteLine("Eliminato");
    }
    public override string ToString()
    {
        return $"'{titolo}' di {autore} ({anno_pubblicazione}).";
    }

    public override bool Equals(object? libro)
    {
        if(libro is Libro libro2)
        {
            return this.titolo == libro2.titolo && this.autore == libro2.autore;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(titolo, autore);
    }

    public Libro copia()
    {
        return (Libro)MemberwiseClone();
    }
}