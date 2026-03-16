class ConFormaggio : IngredienteExtra
{
    public ConFormaggio(IPiatto piatto) : base(piatto)
    {
    }
    public override string Descrizione()
    {
        return $"{piatto_decorato.Descrizione()} + Formaggio";
    }

    public override string Prepara()
    {
        return piatto_decorato.Prepara();
    }
}