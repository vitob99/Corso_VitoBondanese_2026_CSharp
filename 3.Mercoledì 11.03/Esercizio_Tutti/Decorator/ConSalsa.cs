class ConSalsa : IngredienteExtra
{
    public ConSalsa(IPiatto piatto) : base(piatto)
    {
    }

    public override string Descrizione()
    {
        return $"{piatto_decorato.Descrizione()} + Salsa";
    }

    public override string Prepara()
    {
        return piatto_decorato.Prepara();
    }
}