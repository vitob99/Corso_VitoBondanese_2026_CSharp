abstract class IngredienteExtra : IPiatto
{
    protected IPiatto piatto_decorato;
    
    public IngredienteExtra(IPiatto piatto)
    {
        piatto_decorato = piatto;
    }
    abstract public string Descrizione();
    abstract public string Prepara();
}