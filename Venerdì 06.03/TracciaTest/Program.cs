using System;

class Program
{
    public static void Main(string[] args)
    {

        /*
            - La classe InterfacciaUtente gestisce i menù
            - Manca la possibilità di modificare i dati di un animale
            - Manca qualche gestione di eventi da inserimento non previsti
        */

        List<Animale> lista_animali = new List<Animale>();

        bool esci_menu = false;
        int scelta_menu;
        do
        {
            scelta_menu = InterfacciaUtente.MenuPrincipale(); //menu principale
            switch (scelta_menu)
            {
                case 1:  //inserisci pecora
                    string nome_pecora = "";
                    int eta_pecora = 0;
                    double peso_pecora = 0.0d;
                    bool tosata = false;
                    InterfacciaUtente.MenuInserimentoPecora(ref nome_pecora, ref eta_pecora, ref peso_pecora, ref tosata);
                    lista_animali.Add(new Pecora(nome_pecora, eta_pecora, peso_pecora, tosata));
                    Console.WriteLine("Nuova Pecora inserita con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2: //inserisci gallina
                    string nome_gallina = "";
                    int eta_gallina = 0;
                    double peso_gallina = 0.0d;
                    int numero_uova = 0;
                    InterfacciaUtente.MenuInserimentoGallina(ref nome_gallina, ref eta_gallina, ref peso_gallina, ref numero_uova);
                    lista_animali.Add(new Gallina(nome_gallina, eta_gallina, peso_gallina, numero_uova));
                    Console.WriteLine("Nuova Gallina inserita con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:  //inserisci mucca
                    string nome_mucca = "";
                    int eta_mucca = 0;
                    double peso_mucca = 0.0d;
                    int numero_macchie = 0;
                    InterfacciaUtente.MenuInserimentoMucca(ref nome_mucca, ref eta_mucca, ref peso_mucca, ref numero_macchie);
                    lista_animali.Add(new Mucca(nome_mucca, eta_mucca, peso_mucca, numero_macchie));
                    Console.WriteLine("Nuova Mucca inserita con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 4: //inserisci maiale
                    string nome_maiale = "";
                    int eta_maiale = 0;
                    double peso_maiale = 0.0d;
                    bool sporco = false;
                    InterfacciaUtente.MenuInserimentoMaiale(ref nome_maiale, ref eta_maiale, ref peso_maiale, ref sporco);
                    lista_animali.Add(new Maiale(nome_maiale, eta_maiale, peso_maiale, sporco));
                    Console.WriteLine("Nuovo Maiale inserita con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 5:  //rimuovi animale
                    Console.Clear();
                    int n_animali_presenti = lista_animali.Count;
                    if(n_animali_presenti > 0)
                    {
                        string nome_animale_da_eliminare = InterfacciaUtente.MenuEliminaAnimale();
                        bool trovato = false;
                        for (int i = n_animali_presenti - 1; i >= 0; i--)
                        {
                            if (lista_animali[i].Nome == nome_animale_da_eliminare)
                            {
                                Console.WriteLine($"La/Il {lista_animali[i].GetType().Name} '{nome_animale_da_eliminare}' e' stato/a rimosso/a!");
                                lista_animali.RemoveAt(i);
                                trovato = true;
                            }
                        }
                        if (!trovato)
                        {
                            Console.WriteLine("Animale da eliminare non trovato!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non ci sono animali registrati!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 6: //lista animali
                    Console.Clear();
                    int n_animali_lista = lista_animali.Count;
                    if(n_animali_lista > 0)
                    {
                        foreach(Animale a in lista_animali)
                        {
                            Console.WriteLine($"Animale: {a.GetType().Name}");
                            a.InfoAnimale();
                            a.EmettiVerso();
                            a.Gioca();
                            a.Salta();
                            a.Mangia();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non ci sono animali registrati!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 7: //esci
                    esci_menu = true;
                    break;
            }
        }while(esci_menu == false);
    }
}