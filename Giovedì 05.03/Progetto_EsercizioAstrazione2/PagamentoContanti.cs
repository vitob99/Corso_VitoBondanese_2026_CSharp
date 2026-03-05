class PagamentoContanti : MetodoDiPagamentoBase
{
    public PagamentoContanti() : base("Contanti"){}

    public override void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti");
    }

    public override void MostraMetodo()
    {
        Console.WriteLine("Metodo: Contanti");
    }
}