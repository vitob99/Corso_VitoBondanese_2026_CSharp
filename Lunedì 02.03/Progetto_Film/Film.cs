class Film
{
    public string titolo{get; set;}
    public string regista{get; set;}
    public int anno{get; set;}
    public string genere {get; set;}

    public Film(string titolo, string regista, int anno, string genere)
    {
        this.titolo = titolo;
        this. regista = regista;
        this.anno = anno;
        this.genere = genere;
    }

    public override string ToString()
    {
        return $"Titolo: {titolo}\nRegista: {regista}\nAnno: {anno}\nGenere: {genere}";
    }

    public override bool Equals(object? f)
    {
        if(f is Film f2)
        {
            return titolo == f2.titolo && regista == f2.regista && anno == f2.anno && genere == f2.genere;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(titolo, regista, anno, genere);
    }
}