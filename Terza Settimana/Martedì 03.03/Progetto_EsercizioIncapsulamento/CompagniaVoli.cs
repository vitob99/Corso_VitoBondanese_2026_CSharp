class CompagniaVoli
{
    private List<VoloAereo> lista_voli;


    public CompagniaVoli()
    {
        lista_voli = new List<VoloAereo>();
    }

    public VoloAereo getVolo(VoloAereo v)
    {
        foreach(VoloAereo volo in lista_voli)
        {
            if (volo.Equals(v))
            {
                return volo;
            }
        }
        return null;
    }
    public void aggiungi(VoloAereo v)
    {
        lista_voli.Add(v);
    }

    public void CancellaVolo(VoloAereo v)
    {
        if (lista_voli.Remove(v))
        {
            Console.WriteLine("Volo annullato con successo!");
        }
        else
        {
            Console.WriteLine("Il volo selezionato non e' presente");
        }
    }

    public void MostraVoli()
    {
        foreach(VoloAereo v in lista_voli)
        {
            v.VisualizzaStato();
        }
    }


}