using System;

class Program
{
    public enum TipoNemico{Zombie, Robot, Fantasma}
    public enum GiornoSettimana{Lunedì, Martedì, Mercoledì, Giovedì, Venerdì, Sabato, Domenica}
    public enum LivelloAccesso{Ospite, Utente, Admin}
    public enum TipoTransazione {Acquisto, Rimborso, Trasferimento}


    private static int percentualeCommissioni(TipoTransazione t)
    {
        int percentuale = 0;
        switch (t)
        {
            case TipoTransazione.Acquisto:
                percentuale = 5;
                break;
            case TipoTransazione.Rimborso:
                percentuale = 10;
                break;
            case TipoTransazione.Trasferimento:
                percentuale = 15;
                break;
        }

        return percentuale;
    }
    public static void Main(string[] args)
    {
        
        TipoNemico tipo = TipoNemico.Robot;
        switch(tipo)
        {
            case TipoNemico.Zombie:
                Console.WriteLine("Zombie");
                break;
            case TipoNemico.Robot:
                Console.WriteLine("Robot");
                break;
            case TipoNemico.Fantasma:
                Console.WriteLine("Fantasma");
                break;
        }

        /*
            Esercizio 1
            Definisci un enum chiamato GiornoSettimana con i giorni da Lunedì a Domenica. 
            Stampa un messaggio diverso a seconda del giorno selezionato.
        */
        GiornoSettimana giorno = GiornoSettimana.Giovedì;
        switch(giorno)
        {
            case GiornoSettimana.Lunedì:
                Console.WriteLine("Lunedì");
                break;
            case GiornoSettimana.Martedì:
                Console.WriteLine("Martedì");
                break;
            case GiornoSettimana.Mercoledì:
                Console.WriteLine("Mercoledì");
                break;
            case GiornoSettimana.Giovedì:
                Console.WriteLine("Giovedì");
                break;
            case GiornoSettimana.Venerdì:
                Console.WriteLine("Venerdì");
                break;
            case GiornoSettimana.Sabato:
                Console.WriteLine("Sabato");
                break;
            case GiornoSettimana.Domenica:
                Console.WriteLine("Domenica");
                break;            
        }
        
        /*
            Esercizio 2
            Crea un enum chiamato LivelloAccesso con i valori: Ospite, Utente, Amministratore.
            Scrivi un metodo che accetta questo enum e stampa i privilegi disponibili per ciascun livello.
        */

        LivelloAccesso livello = LivelloAccesso.Admin;
        Console.WriteLine("Privilegi: ");
        switch (livello)
        {
            case LivelloAccesso.Ospite:
                Console.WriteLine("- Visualizzazione");
                break;
            case LivelloAccesso.Utente:
                Console.WriteLine("- Visualizzazione");
                Console.WriteLine("- Condivisione");
                break;
            case LivelloAccesso.Admin:
                Console.WriteLine("- Visualizzazione");
                Console.WriteLine("- Condivisione");
                Console.WriteLine("- Modifica");
                break;
        }

        /*
            Esercizio 3
            Definisci un enum chiamato TipoTransazione (con valori come Acquisto, Rimborso, Trasferimento).
            Implementa una funzione che calcola in modo diverso le commissioni in base al tipo di transazione passato come parametro.
        */
        TipoTransazione tipo_t;
        tipo_t = TipoTransazione.Rimborso;
        int percentuale = percentualeCommissioni(tipo_t);




    }    
}  