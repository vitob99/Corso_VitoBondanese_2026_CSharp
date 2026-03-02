using System;

class Program
{   
    private static int sceltaMenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci Film");
        Console.WriteLine("[2] Cerca Film");
        Console.WriteLine("[3] Lista Film");
        Console.WriteLine("[4] Esci");
        Console.Write("Scelta: ");
        int scelta = int.Parse(Console.ReadLine()!);
        return scelta;
    }



    public static void Main(string[] args)
    {
        List<Film> lista_film = new List<Film>();

        int scelta;
        bool esci = false;
        do
        {
            scelta = sceltaMenuPrincipale();
            switch (scelta)
            {
                case 1:
                    string titolo;
                    string regista;
                    int anno;
                    string genere;
                    bool esci_inserimento = false;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("INSERIMENTO FILM");
                        Console.Write("Titolo: ");
                        titolo = Console.ReadLine()!;
                        Console.Write("Regista: ");
                        regista = Console.ReadLine()!;
                        Console.Write("Anno: ");
                        anno = int.Parse(Console.ReadLine()!);
                        Console.Write("Genere: ");
                        genere = Console.ReadLine()!;
                        lista_film.Add(new Film(titolo, regista, anno, genere));
            
                        Console.Write("Vuoi inserire un altro film? (y/n): ");
                        char scelta_reset = char.Parse(Console.ReadLine()!);
                        switch (scelta_reset)
                        {
                            case 'n':
                                esci_inserimento = true;
                                break;
                        }
                    }while(esci_inserimento == false);

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();

                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("CERCA FILM");
                    Console.Write("Genere: ");
                    string genere_cercato = Console.ReadLine()!;
                    bool trovato_min_uno = false;
                    Console.Clear();
                    foreach(Film f in lista_film)
                    {
                        if(f.genere == genere_cercato)
                        {
                            trovato_min_uno = true;
                            Console.WriteLine(f);
                            Console.WriteLine();
                        }
                    }

                    if (!trovato_min_uno)
                    {
                        Console.WriteLine($"Nessun film corrisponde al genere cercato '{genere_cercato}'!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("LISTA FILM");
                    if(lista_film.Count > 0)
                    {
                        foreach(Film f in lista_film)
                        {
                            Console.WriteLine(f);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun film presente!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 4:
                    esci = true;
                    break;
            }
        }while(esci == false);
    }
}