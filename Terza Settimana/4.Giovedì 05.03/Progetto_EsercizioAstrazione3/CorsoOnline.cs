class CorsoOnline : Corso
{
    private string piattaforma;
    private string link_accesso; 

    public string Piattaforma
    {
        get{return piattaforma;}
        set{piattaforma = value;}
    }
    public string LinkAccesso
    {
        get{return link_accesso;}
        set{link_accesso = value;}
    }

    public CorsoOnline(string nome_corso, int durata, string piattaforma, string link_accesso) : base(nome_corso, durata)
    {
        this.piattaforma = piattaforma;
        this.link_accesso = link_accesso;
    }
    public override void ErogaCorso()
    {
        Console.WriteLine($"Nome corso: {base.Titolo}\nDurata: {base.DurataOre}");
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"Piattaforma: {piattaforma}\nLink: {link_accesso}");
    }
}