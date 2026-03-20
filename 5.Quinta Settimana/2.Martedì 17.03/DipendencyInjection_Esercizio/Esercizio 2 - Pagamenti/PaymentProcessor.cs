class PaymentProcessor
{
    private readonly IPaymentGateway pagamento;
    public PaymentProcessor(IPaymentGateway dipendenza_pagamento)
    {
        pagamento = dipendenza_pagamento;
    }

    public void EseguiPagamento(float amount)
    {
        pagamento.Paga(amount);
    }
}