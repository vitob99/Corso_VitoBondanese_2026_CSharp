class CorsoDanza : Corso
{
    string stile;

    public CorsoDanza(string nome_corso, int durata_ore, string docente, string stile) : base(nome_corso, durata_ore, docente)
    {
        this.stile = stile;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Stile: {stile}";
    }

    public override void MetodoSpeciale()
    {
       Console.WriteLine($"Esecuzione coreografia nello stile: [{stile}]");
    }
}