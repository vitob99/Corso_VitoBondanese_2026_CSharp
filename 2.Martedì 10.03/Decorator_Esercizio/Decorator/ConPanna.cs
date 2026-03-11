class ConPanna : DecoratoreBevanda
{
    private const double COSTO_PANNA = 0.50d;
    public ConPanna(IBevanda bevanda_da_decorare) : base(bevanda_da_decorare)
    {
    }

    public override double Costo()
    {
        return bevanda_decorator.Costo() + COSTO_PANNA;
    }

    public override string Descrizione()
    {
        return $"{bevanda_decorator.Descrizione()} + Panna({COSTO_PANNA}$)";
    }
}