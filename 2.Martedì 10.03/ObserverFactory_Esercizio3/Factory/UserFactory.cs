class UserFactory
{
    public static Utente Crea(string nome)
    {
        if(nome == "")
        {
            return null!;
        }
        return new Utente(nome);
    }
}