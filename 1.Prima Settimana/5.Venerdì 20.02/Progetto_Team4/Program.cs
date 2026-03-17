using System;
using System.Runtime.CompilerServices;

class Program{
    const int N_GUSTI = 5;
    const double SOGLIA_SCONTO = 50.0d;
    private static double[] prezzi_gusto;
    private static string[] gusti_gelato;

     private static double CalcolaTotale( int gusto_gelato , int quantita)
    {
        double calcolo_totale = prezzi_gusto[gusto_gelato] * quantita;
        return calcolo_totale;
    }
    private static void StampaMenu(string[] gusti, double[] prezzi)
    {
        for(int i = 0; i < gusti.Length; i++)
        {
            Console.WriteLine($"[{i}]{gusti[i]}: {prezzi[i]}$ per pallina");
        }
    }

    public static void Main(string[] args)
    {
        gusti_gelato = new string[N_GUSTI];
        gusti_gelato[0] = "Ciaccolato";
        gusti_gelato[1] = "Vaniglia";
        gusti_gelato[2] = "Fragola";
        gusti_gelato[3] = "Pistacchio";
        gusti_gelato[4] = "Limone";
        prezzi_gusto = new double[N_GUSTI];
        prezzi_gusto[0] = 0.50;
        prezzi_gusto[1] = 0.30;
        prezzi_gusto[2] = 0.25;
        prezzi_gusto[3] = 0.65;
        prezzi_gusto[4] = 0.60;



       double totale = 0.0;
       int scelta_gusto;
       int scelta_ripeti;
       int n_palline;
       
        List<int> lista_gusti = new List<int>();
        List<int> lista_quantita = new List<int>();
        Console.WriteLine($"Sconto del 10% per ordini superiori a {SOGLIA_SCONTO} euro!");
        bool nuovo_gusto;
        do
        {//CICLO CONTROLLO NUOVO GUSTO - Il ciclo che riparte se nuovo_gusto e' vera, l'utente sta aggiungendo un altro gusto
            nuovo_gusto = false;
            StampaMenu(gusti_gelato, prezzi_gusto);
            bool reset_gusto = false;
            do //CICLO PER IL CONTROLLO SULL'INPUT GUSTO - Seguendo i requisiti
            {
                Console.Write("Scegli un gusto (0 a 4): ");
                scelta_gusto = int.Parse(Console.ReadLine());
                if(scelta_gusto < 0 || scelta_gusto > (gusti_gelato.Length - 1))
                {
                    Console.WriteLine("Errore: Inserisci un numero tra 0 e 4!");
                    reset_gusto = true;
                }
                else
                {
                    lista_gusti.Add(scelta_gusto);
                    reset_gusto = false;
                }              
            }while(reset_gusto);


            bool reset_palline = false;
            do  //CICLO PER IL CONTROLLO SULL'INPUT PALLINE - Seguendo i requisiti
            {
                Console.Write("Quante palline?: ");
                n_palline = int.Parse(Console.ReadLine());
                if(n_palline < 0)
                {
                    Console.WriteLine("Errore: Inserisci un numero positivo!");
                    reset_palline = true;
                }
                else
                {
                    lista_quantita.Add(n_palline);
                    reset_palline = false;                   
                }    
            }while(reset_palline);

            //aggiungo al totale il prezzo per il gusto con relativa quantità, totale andrà a sommarsi finchè l'utente vorrà inserire altri gusti
            
            totale += CalcolaTotale(scelta_gusto, n_palline);
             
            bool reset_conferma = false;
            do //LOOP CHE RIPARTE IN CASO DI SCELTA NON CORRETTA
            {
                Console.WriteLine("Aggiungi un nuovo gusto");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No, calcolami il totale");
                Console.Write("Scelta: ");
                scelta_ripeti = int.Parse(Console.ReadLine());
                switch (scelta_ripeti)
                {
                    case 1:
                        break;
                    case 2:
                        reset_conferma = false;  
                        nuovo_gusto = true;  //CHIEDE UN ALTRO GUSTO
                        break;
                    default:
                        reset_conferma = true;
                        Console.WriteLine("Scelta non valida!");
                        break;
                }                
            }while(reset_conferma);
        }while(!nuovo_gusto);
    





        //GENERAZIONE RIEPILOGO ORDINE
        int totale_ordini = lista_gusti.Count;
        for(int i = 0; i < totale_ordini; i++)
        {
 
            Console.WriteLine($"- {gusti_gelato[lista_gusti[i]]} x{lista_quantita[i]} => { CalcolaTotale(lista_gusti[i], lista_quantita[i])} euro");

        }
        if(totale > SOGLIA_SCONTO)
        {
            Console.WriteLine($"- TOTALE PARZIALE: => {Math.Round(totale, 2)} euro");
            totale -= (totale * 10 / 100); 
            Console.WriteLine("- Sconto del 10%");
        }
        Console.WriteLine($"- TOTALE: => {Math.Round(totale, 2)} euro");
    }  
}



 
    


