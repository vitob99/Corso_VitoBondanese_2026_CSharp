class BitcoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Effettuato pagamento di {amount} Bitcoin");
    }
}