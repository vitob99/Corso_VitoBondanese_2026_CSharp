class SommaStrategia : IStrategiaOperazione
{
    public double Calcola(double a, double b)
    {
        return a + b;
    }

    public string NomeOperazione()
    {
        return "Somma";
    }
}