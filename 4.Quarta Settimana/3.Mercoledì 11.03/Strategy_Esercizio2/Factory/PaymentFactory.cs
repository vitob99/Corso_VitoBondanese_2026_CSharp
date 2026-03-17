public class PaymentFactory
{
    public static IPaymentStrategy? CreaPagamento(int scelta)
    {
        switch (scelta)
        {
            case 1:
                return new PayPalPayment();
            case 2:
                return new BitcoinPayment();
            case 3:
                return new CreditCardPayment();
            default:
                return null;
        }
    }
}