abstract class DecoratoreTorta : ITorta
{
    protected ITorta baseTorta;

    public DecoratoreTorta(ITorta base_torta)
    {
        baseTorta = base_torta;
    }
    abstract public string Descrizione();
}