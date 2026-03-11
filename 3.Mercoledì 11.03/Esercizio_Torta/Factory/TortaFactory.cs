class TortaFactory
{
    public static ITorta? CreaTortaBase(string tipo)
    {
       
        Pasticceria.Instance.Registra(new NegozioMilano());
        Pasticceria.Instance.Registra(new NegozioRoma());

        switch (tipo)
        {
            case "cioccolato":
                return new TortaCioccolato();
            case "vaniglia":
                return new TortaVaniglia();
            case "frutta":
                return new TortaFrutta();
            default:
                return null;
        }
    }
}