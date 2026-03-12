class PiattoFactory
{
    //la classe factory che restituisce oggetti in base al tipo scelto
    public static IPiatto? Crea(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "pizza":
                return new Pizza();
            case "hamburger":
                return new Hamburger();
            case "insalata":
                return new Insalata();
            default:
                return null;
        }
    }
}