using System;

class Program
{
    private static int MenuPrincipale()
    {
        Console.Clear();
        Console.WriteLine("[1] Aggiungere un nuovo operatore di uno dei tre tipi");
        Console.WriteLine("[2] Stampare tutti gli operatori con nome, tipo e turno");
        Console.WriteLine("[3] Chiamare EseguiCompito() su tutti (polimorfismo)");
        Console.WriteLine("[0] Uscire");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static int MenuSceltaOperatore()
    {
        Console.Clear();
        Console.WriteLine("[1] Operatore Emergenze");
        Console.WriteLine("[2] Operatore Sicurezza");
        Console.WriteLine("[3] Operatore Logistica");
        Console.WriteLine("[0] Indietro");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);
    }

    public static void Main(string[] args)
    {
        List<Operatore> elenco_operatori = new List<Operatore>();


        bool esci = false;
        int scelta_menu;
        do
        {
            scelta_menu = MenuPrincipale();
            switch (scelta_menu)
            {
                case 1:
                    Console.WriteLine("AGGIUNGI OPERATORE");
                    bool esci_operatore = false;
                    int scelta_menu_operatore;
                    do{
                        scelta_menu_operatore = MenuSceltaOperatore();
                        switch (scelta_menu_operatore)
                        {
                            case 1:
                                Console.Clear();
                                Console.Write("Nome Operatore Emergenze: ");
                                string nome_operatore_emergenze = Console.ReadLine()!;
                                Console.Write("Turno: ");
                                string turno_operatore_emergenze = Console.ReadLine()!;
                                Console.Write("Livello urgenza: ");
                                int livello_urgenza = int.Parse(Console.ReadLine()!);
                                elenco_operatori.Add(new OperatoreEmergenza(nome_operatore_emergenze, turno_operatore_emergenze, livello_urgenza));
                                Console.WriteLine($"Operatore emergernze '{nome_operatore_emergenze}' aggiunto!");
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.Write("Nome Operatore Sicurezza: ");
                                string nome_operatore_sicurezza = Console.ReadLine()!;
                                Console.Write("Turno: ");
                                string turno_operatore_sicurezza = Console.ReadLine()!;
                                Console.Write("Area Sorvegliata: ");
                                string area_sorvegliata = Console.ReadLine()!;
                                elenco_operatori.Add(new OperatoreSicurezza(nome_operatore_sicurezza, turno_operatore_sicurezza, area_sorvegliata));
                                Console.WriteLine($"Operatore sicurezza '{nome_operatore_sicurezza}' aggiunto!");
                                Console.Write("Premi un tasto per continuare...");                      
                                Console.ReadKey();          
                                break;
                            case 3:
                                Console.Clear();
                                Console.Write("Nome Operatore Logistica: ");
                                string nome_operatore_logistica = Console.ReadLine()!;
                                Console.Write("Turno: ");
                                string turno_operatore_logistica = Console.ReadLine()!;
                                Console.Write("Numero consegne: ");
                                int numero_consegne = int.Parse(Console.ReadLine()!);
                                elenco_operatori.Add(new OperatoreLogistica(nome_operatore_logistica, turno_operatore_logistica, numero_consegne));
                                Console.WriteLine($"Operatore logistica '{nome_operatore_logistica}' aggiunto!");
                                Console.Write("Premi un tasto per continuare...");
                                Console.ReadKey();
                                break;
                            case 0:
                                esci_operatore = true;
                                break;
                        }
                    }while(esci_operatore == false);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("LISTA OPERATORI");
                    int n_operatori_lista = elenco_operatori.Count;
                    if(n_operatori_lista > 0){
                        foreach(Operatore o in elenco_operatori)
                        {
                            Console.WriteLine(o);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nessun Operatore presente!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("OPERATORI IN AZIONE");
                    int n_operatori = elenco_operatori.Count;
                    if(n_operatori > 0)
                    {
                        foreach(Operatore o in elenco_operatori)
                        {
                            o.EseguiCompito();
                            Console.WriteLine();
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Nessun Operatore presente!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 0:
                    esci = true;
                    break;
            }
        }while(esci == false);
    }
}