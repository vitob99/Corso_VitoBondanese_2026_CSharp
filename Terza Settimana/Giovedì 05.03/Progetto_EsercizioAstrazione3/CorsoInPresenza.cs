class CorsoInPresenza : Corso
{
    private string aula;
    private int numero_posti; 

    public string Aula
    {
        get{return aula;}
        set{aula = value;}
    }
    public int NumeroPosti
    {
        get{return numero_posti;}
        set
        {
            if(value > 0)
            {
                numero_posti = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public CorsoInPresenza(string nome_corso, int durata, string aula, int numero_posti) : base(nome_corso, durata)
    {
        this.aula = aula;
        NumeroPosti = numero_posti;
    }
    public override void ErogaCorso()
    {
        Console.WriteLine($"Nome corso: {base.Titolo}\nDurata: {base.DurataOre}");
        
    }

    public override void StampaDettagli()
    {
        Console.WriteLine($"Aula: {aula}\nNumero posti: {numero_posti}");
    }
}