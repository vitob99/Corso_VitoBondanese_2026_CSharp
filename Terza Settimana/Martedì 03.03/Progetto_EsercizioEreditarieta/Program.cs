using System;

class Program
{
    private static int SceltaMenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Aggiungi un corso di Musica");
        Console.WriteLine("[2] Aggiungi un corso di Pittura");
        Console.WriteLine("[3] Aggiungi un corso di Danza");
        Console.WriteLine("[4] Aggiungi studente a un corso (con selezione per indice)");
        Console.WriteLine("[5] Visualizza tutti i corsi");
        Console.WriteLine("[6] Cerca corsi per nome docente");
        Console.WriteLine("[7] Esegui metodo speciale di un corso (selezionato per indice)");
        Console.WriteLine("[0] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }
    public static void Main(string[] args)
    {
        List<Corso> lista_corsi = new List<Corso>();
        bool esci = false;
        int scelta_menu;
        do
        {
            scelta_menu = SceltaMenuPrincipale();
            switch (scelta_menu)
            {
                case 1:  //nuovo corso musica
                    Console.Clear();
                    Console.WriteLine("NUOVO CORSO MUSICA");
                    Console.Write("Nome corso: ");
                    string nome_corso_musica = Console.ReadLine()!;
                    Console.Write("Durate in ore: ");
                    int durata_corso_musica = int.Parse(Console.ReadLine()!);
                    Console.Write("Docente: ");
                    string docente_corso_musica = Console.ReadLine()!;
                    Console.Write("Strumento: ");
                    string strumento_corso_musica = Console.ReadLine()!;
                    lista_corsi.Add(new CorsoMusica(nome_corso_musica, durata_corso_musica, docente_corso_musica, strumento_corso_musica));
                    Console.WriteLine($"Corso di Musica '{nome_corso_musica}' aggiunto con successo!");

                    Console.WriteLine("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2: //nuovo corso pittura
                    Console.Clear();
                    Console.WriteLine("NUOVO CORSO PITTURA");
                    Console.Write("Nome corso: ");
                    string nome_corso_pittura = Console.ReadLine()!;
                    Console.Write("Durate in ore: ");
                    int durata_corso_pittura = int.Parse(Console.ReadLine()!);
                    Console.Write("Docente: ");
                    string docente_corso_pittura = Console.ReadLine()!;
                    Console.Write("Tecnica: ");
                    string tecnica_corso_pittura = Console.ReadLine()!;
                    lista_corsi.Add(new CorsoPittura(nome_corso_pittura, durata_corso_pittura, docente_corso_pittura, tecnica_corso_pittura));
                    Console.WriteLine($"Corso di Pittura '{nome_corso_pittura}' aggiunto con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();                
                    break;
                case 3: //nuovo corso danza
                    Console.Clear();
                    Console.WriteLine("NUOVO CORSO DANZA");
                    Console.Write("Nome corso: ");
                    string nome_corso_danza = Console.ReadLine()!;
                    Console.Write("Durate in ore: ");
                    int durata_corso_danza = int.Parse(Console.ReadLine()!);
                    Console.Write("Docente: ");
                    string docente_corso_danza = Console.ReadLine()!;
                    Console.Write("Stile: ");
                    string stile_corso_danza = Console.ReadLine()!;
                    lista_corsi.Add(new CorsoDanza(nome_corso_danza, durata_corso_danza, docente_corso_danza, stile_corso_danza));
                    Console.WriteLine($"Corso di Danza '{nome_corso_danza}' aggiunto con successo!");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();  
                    break;
                case 4: //aggiungi studente al corso
                    Console.Clear();
                    Console.WriteLine("AGGIUNGI STUDENTE AL CORSO");
                    int n_corsi_assegna = lista_corsi.Count;
                    if(n_corsi_assegna > 0)
                    {
                        for(int i = 0; i < n_corsi_assegna; i++)
                        {
                            Console.WriteLine($"Corso [{i + 1}]");
                            Console.WriteLine(lista_corsi[i]);
                            Console.WriteLine();
                        }  
                        int scelta_corso_studente;
                        do
                        {
                            Console.Write("A quale corso vuoi aggiungere lo studente: ");
                            scelta_corso_studente = int.Parse(Console.ReadLine()!);
                            
                        }while(scelta_corso_studente <= 0 || scelta_corso_studente > n_corsi_assegna);

                        Console.Write("Nome studente da aggiungere: ");
                        string nome_studente = Console.ReadLine()!;
                        lista_corsi[scelta_corso_studente - 1].AggiungiStudente(nome_studente);
                        Console.WriteLine($"Studente '{nome_studente}' aggiunto al corso {lista_corsi[scelta_corso_studente - 1].nome_corso}");
                    }
                    else
                    {
                        Console.WriteLine("Nessun corso trovato!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();  
                    break;
                case 5:  //lista corsi
                    Console.Clear();
                    Console.WriteLine("LISTA CORSI");
                    if(lista_corsi.Count > 0)
                    {
                        foreach(Corso c in lista_corsi)
                        {
                            Console.WriteLine(c);
                            Console.WriteLine();
                        }                     
                    }
                    else
                    {
                        Console.WriteLine("Nessun corso trovato!");
                    }


                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();  
                    break;
                case 6: //cerca corso per docente
                    Console.Clear();
                    Console.WriteLine("CERCA CORSO PER DOCENTE");
                    Console.Write("Nome docente: ");
                    string nome_docente_corso = Console.ReadLine()!;
                    bool trovato = false;
                    foreach(Corso c in lista_corsi)
                    {
                        if(c.docente == nome_docente_corso)
                        {
                            Console.WriteLine();
                            trovato = true;
                            Console.WriteLine(c);
                            Console.WriteLine();
                        }
                    }
                    if(trovato == false)
                    {
                        Console.WriteLine($"Non ci sono corsi tenuti dal docente '{nome_docente_corso}'");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey(); 
                    break;
                case 7: //metodo speciale
                    Console.Clear();
                    Console.WriteLine("ESECUZIONE METODO SPECIALE");
                    int n_corsi = lista_corsi.Count;
                    if(n_corsi > 0)
                    {
                        for(int i = 0; i < n_corsi; i++)
                        {
                            Console.WriteLine($"Corso [{i + 1}]");
                            Console.WriteLine(lista_corsi[i]);
                            Console.WriteLine();
                        }  
                        int scelta_metodo_speciale;
                        do
                        {
                            Console.Write("Indice metodo speciale: ");
                            scelta_metodo_speciale = int.Parse(Console.ReadLine()!);
                            
                        }while(scelta_metodo_speciale <= 0 || scelta_metodo_speciale >n_corsi);
                        lista_corsi[scelta_metodo_speciale - 1].MetodoSpeciale();               
                    }
                    else
                    {
                        Console.WriteLine("Nessun corso trovato!");
                    }


                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();  
                    break;
                case 0: //esci
                    esci = true;
                    break;
            }
        }while(esci == false);
    }
}