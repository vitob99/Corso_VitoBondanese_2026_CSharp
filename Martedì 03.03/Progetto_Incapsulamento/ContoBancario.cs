public class ContoBancario
{
    // Campo privato (non accessibile direttamente dall'esterno)
    private double saldo;

    // Proprietà per accedere al saldo in modo controllato
    public double Saldo
    {
        get { return saldo; } // permette la lettura del saldo
        set
        {
            if (value >= 0)
            {
                saldo = value; // solo valori validi
            }           
        }
    }
}