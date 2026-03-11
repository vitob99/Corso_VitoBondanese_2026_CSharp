class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Effettuato pagamento Paypal di {amount}$");
    }
}