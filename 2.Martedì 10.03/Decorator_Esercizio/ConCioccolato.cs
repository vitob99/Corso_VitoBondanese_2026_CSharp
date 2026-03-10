class ConCioccolato : DecoratoreBevanda
{
    private static double COSTO_CIOCCOLATO =  0.60d;
    public ConCioccolato(IBevanda bevanda_da_decorare) : base(bevanda_da_decorare)
    {
        
    }

    public override double Costo()
    {
        return bevanda_decorator.Costo() + COSTO_CIOCCOLATO;
    }

    public override string Descrizione()
    {
        return $"{bevanda_decorator.Descrizione()} + Cioccolato({COSTO_CIOCCOLATO}$)";
    }
}