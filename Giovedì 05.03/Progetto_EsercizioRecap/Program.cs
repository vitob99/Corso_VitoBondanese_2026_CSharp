using System;

class Program
{
    private static bool CercaBadgeInPersone(List<Persona> lista_persone)
    {
        foreach(Persona p in lista_persone)
        {
            if (p.BadgeAccesso())
            {
                
            }
        }
    }

    public static void Main(string[] args)
    {
        List<Persona> lista_persone = new List<Persona>();

        Badge badge_loggato = null;

        bool isLogged = false;
        do
        {
            string id_badge = UserInterface.MenuPrincipale();
            badge_loggato = RaccoltaBadge.CercaBadge(id_badge)!;
            if (badge_loggato != null)
            {
                
            }

        }while(isLogged == false);
        
        
    }
}