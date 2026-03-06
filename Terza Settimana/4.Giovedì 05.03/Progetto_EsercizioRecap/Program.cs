using System;

class Program
{
    private static Badge CercaBadgeInPersone(List<Persona> lista_persone, out Persona persona_loggata, string codice_badge)
    {
        persona_loggata = null!;
        foreach(Persona p in lista_persone)
        {
            if (p.BadgeAccesso.Codice == codice_badge)
            {
                persona_loggata = p;
                return p.BadgeAccesso;
            }
        }
        return null!;
    }


    /*
        - Da inserire il sistema di logout con altri menù dalla classe UserInterface
        - Da inserire il sistema di registrazione log per l'uscita
        - Aggiunta altre features....
    */
    public static void Main(string[] args)
    {
        List<Persona> lista_persone = new List<Persona>();
        lista_persone.Add(new Dipendente("Mario", "Rossi", "FDSFDSSFDFSDFSD", new Badge("DDS", true), "DIP004"));


        Badge badge_loggato;
        Persona persona_loggata;
        bool isLogged = false;
        do
        {
            string id_badge = UserInterface.MenuLogin();


            badge_loggato = CercaBadgeInPersone(lista_persone, out persona_loggata, id_badge);
            if (badge_loggato != null)
            {
                if (!badge_loggato.isAttivo)
                {
                    Console.WriteLine("Il badge non e' momentaneamente attivo!");

                    
                    Console.Write("Premi un tasto per continuare");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"Benvenuto!\n{persona_loggata}");
                    RaccoltaAccessi.Aggiungi(persona_loggata);
                    RaccoltaAccessi.StampaStorico();
                    
                    Console.Write("Premi un tasto per continuare");
                    Console.ReadKey();
                    isLogged = true;
                }
            }
            else
            {
                Console.WriteLine("Errore di accesso: il codice badge inserito non e' valido!");
                Console.Write("Premi un tasto per continuare");
                Console.ReadKey();
            }
        }while(isLogged == false);
        
        
    }
}