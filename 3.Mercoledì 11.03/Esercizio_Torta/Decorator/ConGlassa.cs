class ConGlassa : DecoratoreTorta
{
    public ConGlassa(ITorta base_torta) : base(base_torta)
    {
    }

    public override string Descrizione()
    {
        return $"{baseTorta?.Descrizione()} + Glassa";
    }
}