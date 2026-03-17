class ConLatte : DecoratoreBevanda
{
    private const double COSTO_LATTE = 0.50d;
    public ConLatte(IBevanda bevanda_da_decorare) : base(bevanda_da_decorare)
    {
        
    }

    public override double Costo()
    {
        return bevanda_decorator.Costo() + COSTO_LATTE;
    }

    public override string Descrizione()
    {
        return $"{bevanda_decorator.Descrizione()} + Latte({COSTO_LATTE}$)";
    }
}