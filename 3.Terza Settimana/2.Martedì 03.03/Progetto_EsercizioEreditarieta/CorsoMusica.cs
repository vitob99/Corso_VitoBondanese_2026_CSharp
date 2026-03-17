class CorsoMusica : Corso
{
    string strumento;

    public CorsoMusica(string nome_corso, int durata_ore, string docente, string strumento) : base(nome_corso, durata_ore, docente)
    {
        this.strumento = strumento;
    }

    public override string ToString()
    {
        return $"{base.ToString()}Strumento: {strumento}";
    }

    public override void MetodoSpeciale()
    {
       Console.WriteLine($"Si tiene una prova pratica dello strumento: [{strumento}]");
    }
}