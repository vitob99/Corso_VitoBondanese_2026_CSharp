class VeicoloFactory
{
    public static IVeicolo CreaVeicolo(string tipo)
    {
        if(tipo.ToLower() == "auto")
        {
            return new Auto();
        }
        else if(tipo.ToLower() == "moto")
        {
            return new Moto();
        }
        else if(tipo.ToLower() == "camion")
        {
            return new Camion();
        }

        throw new Exception("Veicolo inesistente!");
    }
}