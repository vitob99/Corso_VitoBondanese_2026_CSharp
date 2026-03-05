abstract class Corso
{
    private string titolo;
    private int durata_ore;

    public string Titolo
    {
        get{return titolo;}

        set{titolo = value;}
        }

    public int DurataOre
    {
        get{return durata_ore;}
        set
        {   
            if(value > 0)
            {
                durata_ore = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    protected Corso(string titolo, int durata_ore)
    {
        this.titolo = titolo;
        DurataOre = durata_ore;
    }
    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}