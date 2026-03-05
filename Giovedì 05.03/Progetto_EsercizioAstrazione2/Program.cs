using System;

class Program
{
    public static void Main(string[] args)
    {
        List<IPagamento> pagamenti = new List<IPagamento>()
        {
            new PagamentoCarta("MasterCard"),
            new PagamentoContanti(),
            new PagamentoPayPal("prova@otmail.it")
        };

        foreach(IPagamento p in pagamenti)
        {
            p.MostraMetodo();
            p.EseguiPagamento(80.5m);
        }
    }
}