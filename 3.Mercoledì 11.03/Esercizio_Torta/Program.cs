using System;

class Program
{
    private static string MenuScegliTorta()
    {
        Console.Clear();
        Console.WriteLine("[cioccolato] - Torta al cioccolato");
        Console.WriteLine("[vaniglia] - Torta alla vaniglia");
        Console.WriteLine("[frutta] - Torta alla frutta");
        Console.WriteLine("[esci] - Esci");
        Console.Write("Scelta: ");
        return Console.ReadLine()!;
    }

    private static string MenuAggiunta(string torta_base)
    {
        Console.Clear();
        Console.WriteLine($"Base: {torta_base}");
        Console.WriteLine("[fragole] - Aggiungi fragole");
        Console.WriteLine("[panna] - Aggiungi panna");
        Console.WriteLine("[glassa] - Aggiungi glassa");
        Console.WriteLine("[fine] - Fine aggiunte");
        Console.Write("Scelta: ");
        return Console.ReadLine()!;
    }

    public static void Main(string[] args)
    {

        //dichiaro i decoratori
        ITorta? torta_generale;
        ITorta? torta_panna = null;
        ITorta? torta_fragole = null;
        ITorta? torta_glassa = null;


        bool esci_menu_torta = false;
        string scelta_menu_torta;
        do
        {
            scelta_menu_torta = MenuScegliTorta(); //menu per la scelta della base torta, si ripete finchè non in serisco una base valida
            if(scelta_menu_torta.ToLower() != "cioccolato" && scelta_menu_torta.ToLower() != "vaniglia" && scelta_menu_torta.ToLower() != "frutta")
            {
                if(scelta_menu_torta.ToLower() == "esci")  //controlla se voglio uscire
                {
                    esci_menu_torta = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Errore: torta non presente");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                }
            }
            else //se è una scelta valida chiedo le aggiunte
            {
                torta_generale = TortaFactory.CreaTortaBase(scelta_menu_torta);
                Console.WriteLine(torta_generale?.Descrizione());

                bool esci_aggiunte = false;
                do
                {
                    string aggiunta = MenuAggiunta(torta_generale!.Descrizione()); //menu per l'aggiunta NOTA: non fatta la gestione errori
                    switch (aggiunta)
                    {
                        case "fragole":
                            //torta_base = new ConFragole(torta_base);
                            torta_fragole = new ConFragole(torta_generale);  //decoro con le fragole partendo dalla base con panna
                            torta_generale = torta_fragole;
                            Console.WriteLine(torta_generale.Descrizione());
                            Console.Write("Premi un tasto per continuare...");
                            Console.ReadKey();                            
                            break;
                        case "panna": 
                            //torta_base = new ConPanna(torta_base);
                            if(torta_fragole != null)
                            {
                                torta_fragole = new ConPanna(torta_fragole);  //decoro con le fragole partendo dalla base con panna
                                torta_generale = torta_fragole;
                                Console.WriteLine(torta_generale.Descrizione());
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Errore: Aggiungi prima le fragole!");
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                            }
                            break;
                        case "glassa":
                            //torta_base = new ConGlassa(torta_base);
                            if(torta_panna != null && torta_fragole != null)
                            {
                                torta_glassa = new ConGlassa(torta_fragole); //decoro con la glassa partendo dalla base con fragole
                                torta_generale = torta_glassa;
                                Console.WriteLine(torta_generale.Descrizione());
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Errore: Aggiungi prima le fragole e la panna!");
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                            }
                            break;
                        case "fine":
                            esci_aggiunte = true;
                            break;
                }
       
                }while(esci_aggiunte == false);
                Console.WriteLine($"Torta completa: {torta_generale!.Descrizione()}");
                Pasticceria.Instance.AggiungiTorta(torta_generale); //aggiungo la torta alla pasticceria per notificare (Observer) i negozi
                Console.Write("Premi un tasto per continuare...");
                Console.ReadKey();
            }   
        }while(esci_menu_torta == false);


    }
}