using System;

class Program
{
    private static int Menu()
    {
        Console.Clear();
        Console.WriteLine("[1] Inserisci dispositivo - Modulo A: ");
        Console.WriteLine("[2] Inserisci dispositivo - Modulo B: ");
        Console.WriteLine("[3] Verifica con ReferenceEquals");
        Console.WriteLine("[4] Stampa configurazioni");
        Console.WriteLine("[5] Avvia e Mostra Tipo");
        Console.WriteLine("[6] Esci");
        Console.Write("Scelta: ");
        return int.Parse(Console.ReadLine()!);

    }
    
    public static void Main(string[] args)
    {
        List<IDispositivo> lista_dispositivi = new List<IDispositivo>();


        // NOTA: Ho dato la possibilità di inserire sia in modulo a che modulo b per mostrare che operano sulla stessa istanza
        
        bool esci = false;
        int scelta;
        do
        {
            scelta = Menu();
            switch (scelta)
            {
                case 1: 
                    bool dispositivo_valido_a = false;
                    do
                    {
                        Console.Clear();
                        Console.Write("Modulo A - Nome dispositivo: ");
                        string nome_dispositivo_a = Console.ReadLine()!;
                        IDispositivo? d = DispositivoFactory.CreaDispositivo(nome_dispositivo_a)!;
                        if(d != null)
                        {
                            dispositivo_valido_a = true;
                            ModuloA.Config.Imposta($"{ConfigurazioneSistema.Instance.ConfigCount() + 1}",nome_dispositivo_a);
                            lista_dispositivi.Add(d);
                            Console.WriteLine($"Dispositivo {nome_dispositivo_a} inserito nel Modulo A");
                        }
                        else
                        {
                            Console.WriteLine($"Impossibile aggiungere il dispositivo '{nome_dispositivo_a}' al Modulo A, riprova!");
                            Console.Write("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                    }while(dispositivo_valido_a == false);


                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 2:
                    bool dispositivo_valido_b = false;
                    do
                    {
                        Console.Clear();
                        Console.Write("Modulo B - Nome dispositivo: ");
                        string nome_dispositivo_b = Console.ReadLine()!;
                        IDispositivo? d = DispositivoFactory.CreaDispositivo(nome_dispositivo_b)!;
                        if(d != null)
                        {
                            dispositivo_valido_b = true;
                            ModuloB.Config.Imposta($"{ConfigurazioneSistema.Instance.ConfigCount() + 1}",nome_dispositivo_b);
                            lista_dispositivi.Add(d);
                            Console.WriteLine($"Dispositivo {nome_dispositivo_b} inserito nel Modulo A");
                        }
                        else
                        {
                            Console.WriteLine($"Impossibile aggiungere il dispositivo '{nome_dispositivo_b}' al Modulo B, riprova!");
                            Console.Write("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                    }while(dispositivo_valido_b == false);


                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine($"Le due istanze sono uguali: {Object.ReferenceEquals(ModuloA.Config, ModuloB.Config)}");

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("LISTA CONFIGURAZIONI");

                    ConfigurazioneSistema.Instance.StampaTutte();

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 5: 
                    Console.Clear();
                    Console.WriteLine("AVVIAMENTO E TIPO");

                    int n_dispositivi = lista_dispositivi.Count;
                    if(n_dispositivi > 0)
                    {
                        for(int i = 0; i < lista_dispositivi.Count; i++)
                        {
                            Console.WriteLine($"[{i + 1}]");
                            lista_dispositivi[i].Avvia();
                            lista_dispositivi[i].MostraTipo();
                            Console.WriteLine();
                        }                        
                    }
                    else
                    {
                        Console.WriteLine("Non ci sono dispositivi registrati!");
                    }

                    Console.Write("Premi un tasto per continuare...");
                    Console.ReadKey();
                    break;
                case 6:
                    esci = true;
                    break;
            }
        }while(esci == false);
        

    }
}