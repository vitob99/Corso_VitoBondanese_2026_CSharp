class PaymentContext : IPaymentStrategy
{
    private IPaymentStrategy? strategy_pagamento;

    public void ImpostaStrategia(IPaymentStrategy nuovaStrategia){
        strategy_pagamento = nuovaStrategia;
    }
    
    public void Pay(decimal amount)
    {
        strategy_pagamento?.Pay(amount);
    }
}