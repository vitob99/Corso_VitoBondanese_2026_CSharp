class ConBacon : IngredienteExtra
{
    public ConBacon(IPiatto piatto) : base(piatto)
    {
    }

    public override string Descrizione()
    {
        return $"{piatto_decorato.Descrizione()} + Bacon";
    }

    public override string Prepara()
    {
        return piatto_decorato.Prepara();
    }
}