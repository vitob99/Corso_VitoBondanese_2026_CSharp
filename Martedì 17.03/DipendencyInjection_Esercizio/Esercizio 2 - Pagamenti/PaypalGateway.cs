class PaypalGateway : IPaymentGateway
{
    public void Paga(float amount)
    {
        Console.WriteLine($"Pagati {amount}$ con PayPal!");
    }
}