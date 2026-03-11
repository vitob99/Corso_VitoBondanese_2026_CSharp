class ConPanna : DecoratoreTorta
{
    public ConPanna(ITorta base_torta) : base(base_torta)
    {
    }

    public override string Descrizione()
    {
        return $"{baseTorta?.Descrizione()} + Panna";
    }
}