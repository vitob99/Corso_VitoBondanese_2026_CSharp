class PiattoFactory
{
    public static IPiatto? Crea(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "pizza":
                return new Pizza();
            case "hambuger":
                return new Hamburger();
            case "insalata":
                return new Insalata();
            default:
                return null;
        }
    }
}