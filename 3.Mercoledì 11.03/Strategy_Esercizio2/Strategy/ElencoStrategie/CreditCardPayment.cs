class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Effettuato pagamento di {amount}$ con Carta");
    }
}