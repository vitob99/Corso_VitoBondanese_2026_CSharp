class CorsoPittura : Corso
{
    string tecnica;

    public CorsoPittura(string nome_corso, int durata_ore, string docente, string tecnica) : base(nome_corso, durata_ore, docente)
    {
        this.tecnica = tecnica;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Tecnica: {tecnica}";
    }

    public override void MetodoSpeciale()
    {
       Console.WriteLine($"Si lavora su una tela con tecnica: [{tecnica}]");
    }
}