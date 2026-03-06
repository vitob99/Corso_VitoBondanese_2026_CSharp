class PagamentoCarta : MetodoDiPagamentoBase
{
    private string circuito;
    public string Circuito
    {
        get { return circuito; }
        set { circuito = value; }
    }

    public PagamentoCarta(string circuito) : base("Carta di Credito")
    {
        this.circuito = circuito;
    }

    public override void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta (Circuito: {circuito})");
    }

    public override void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Carta di credito");
    }
}