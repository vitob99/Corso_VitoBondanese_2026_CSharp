class DivisioneStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a / b;
    }

    public string NomeOperazione()
    {
        return "Divisione";
    }
}