class ConFragole : DecoratoreTorta
{
    public ConFragole(ITorta base_torta) : base(base_torta)
    {
    }

    public override string Descrizione()
    {
        return $"{baseTorta?.Descrizione()} + Fragole";
    }
}