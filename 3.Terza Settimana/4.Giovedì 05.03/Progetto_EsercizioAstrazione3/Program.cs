using System;


class Program
{
    private static int MenuCorsi()
    {
        Console.Clear();
        Console.WriteLine("[1] Aggiungi Corso in presenza");
        Console.WriteLine("[2] Aggiungi Corso online");
        Console.WriteLine("[3] Aggiungi Docente");
        Console.WriteLine("[4] Assegna Corso");
        Console.WriteLine("[5] Lista Docenti");
        Console.WriteLine("[6] Lista Corsi");
        Console.WriteLine("[7] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }


    public static void Main(string[] args)
    {
        
        List<Corso> corsi = new List<Corso>();
        List<Docente> docenti = new List<Docente>();

        bool esci_menu_corsi = false;
        int scelta_menu_corsi;
        do
        {
            scelta_menu_corsi = MenuCorsi();
            switch (scelta_menu_corsi)
            {
                case 1: //aggiungi corso in presenza
                    Console.Clear();
                    Console.Write("Nome corso in presenza: ");
                    string nome_corso_presenza = Console.ReadLine()!;
                    Console.Write("Durata: ");
                    int durata_corso_presenza = int.Parse(Console.ReadLine()!);
                    Console.Write("Aula: ");
                    string aula_corso_presenza = Console.ReadLine()!;
                    Console.Write("Numero posti: ");
                    int numero_posti = int.Parse(Console.ReadLine()!);
                    corsi.Add(new CorsoInPresenza(nome_corso_presenza, durata_corso_presenza, aula_corso_presenza, numero_posti));
                    Console.WriteLine($"Corso in presenza '{nome_corso_presenza}' aggiunto con successo!");

                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2: //aggiungi corso online
                    Console.Clear();
                    Console.Write("Nome corso online: ");
                    string nome_corso_online = Console.ReadLine()!;
                    Console.Write("Durata: ");
                    int durata_corso_online = int.Parse(Console.ReadLine()!);
                    Console.Write("Piattaforma: ");
                    string nome_piattaforma = Console.ReadLine()!;
                    Console.Write("Link: ");
                    string link_piattaforma = Console.ReadLine()!;
                    corsi.Add(new CorsoOnline(nome_corso_online, durata_corso_online, nome_piattaforma, link_piattaforma));
                    Console.WriteLine($"Corso online '{nome_corso_online}' aggiunto con successo!");

                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();                    
                    break;    
                case 3: //aggiungi docente
                    Console.Clear();
                    Console.Write("Nome docente: ");
                    string nome_docente = Console.ReadLine()!;
                    Console.Write("Materia: ");
                    string materia_docente = Console.ReadLine()!;
                    
                    docenti.Add(new Docente(nome_docente, materia_docente));
                    Console.WriteLine($"Docente '{nome_docente}' aggiunto con successo!");

                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();   
                    break;
                case 4: //assegna corso
                    
                    //DA FARE


                    //- da effettuare il collegamento e l'assegnazione di un corso a un docente !!!!



                    break;      
                case 5: //lista docenti
                    Console.Clear();
                    Console.WriteLine("LISTA DOCENTI");
                    int n_docenti = docenti.Count;
                    if(n_docenti > 0)
                    {
                        foreach(Docente d in docenti)
                        {
                            Console.WriteLine(d);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non ci sono docenti registrati!");
                    }

                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();  
                    break; 
                case 6:
                    Console.Clear();
                    Console.WriteLine("LISTA CORSI");
                    int n_corsi = corsi.Count;
                    if(n_corsi > 0)
                    {
                        foreach(Corso c in corsi)
                        {
                            c.ErogaCorso();
                            c.StampaDettagli();
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Non ci sono corsi registrati!");
                    }

                    Console.WriteLine();
                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();  
                    break;     
                case 7:
                    esci_menu_corsi = true;
                    break;                                             
            }
        }while(esci_menu_corsi == false);
    }
}