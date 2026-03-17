class CreditCardGateway : IPaymentGateway
{
    public void Paga(float amount)
    {
        Console.WriteLine($"Pagati {amount}$ con Carta di Credito!");
    }
}