sealed class RegistroVeicoli
{
    private static RegistroVeicoli? istanza;
    private List<IVeicolo> veicoliCreati;

    private RegistroVeicoli()
    {
        veicoliCreati = new List<IVeicolo>();
    }

    public static RegistroVeicoli Instance
    {
        get
        {
            if(istanza == null)
            {
                istanza = new RegistroVeicoli();
            }
            return istanza;
        }
    }

    public void Registra(IVeicolo veicolo)
    {
        veicoliCreati.Add(veicolo);
    }
    public void StampaTutti()
    {
        for(int i = 0; i < veicoliCreati.Count; i++)
        {
            Console.WriteLine($"[{i + 1}]");
            veicoliCreati[i].Avvia();
            veicoliCreati[i].MostraTipo();
            Console.WriteLine();
        }
    }

}