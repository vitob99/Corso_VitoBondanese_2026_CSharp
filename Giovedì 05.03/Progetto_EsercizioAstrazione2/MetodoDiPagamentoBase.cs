public abstract class MetodoDiPagamentoBase : IPagamento
{
    public string metodo_pagamento { get; }


    public MetodoDiPagamentoBase(string nomeMetodo)
    {
        metodo_pagamento = nomeMetodo;

    }

    public virtual void MostraMetodo()
    {
        Console.WriteLine($"Metodo di pagamento: {metodo_pagamento}");
    }

    public abstract void EseguiPagamento(decimal importo);

    public void StampaRicevuta(decimal importo)
    {
        Console.WriteLine($"Totale: {importo}");
    }
}