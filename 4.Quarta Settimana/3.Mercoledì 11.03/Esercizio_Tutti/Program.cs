using System;

class Program
{
    public static void Main(string[] args)
    {
        IPiatto? piatto_generale;

        bool esci = false;
        string scelta_piatto;
        string scelta_extra;
        do
        {
            scelta_piatto = InterfacciaUtente.MenuSceltaPiattiBase(); //scelgo il piatto
            if (scelta_piatto.ToLower() == "esci")
            {
                esci = true;
            }
            else
            {
                bool aggiunto_formaggio = false;
                bool aggiunto_bacon = false;
                bool aggiunta_salsa = false;
                piatto_generale = PiattoFactory.Crea(scelta_piatto); //creo il piatto tramite factory
                Chef.Instance.Registra(new NegozioA());  //aggiungo gli osservatori
                Chef.Instance.Registra(new NegozioB());
                do
                {
                    scelta_extra = InterfacciaUtente.MenuSceltaExtra(piatto_generale!);  //gestisco il menù delle aggiunte verificando se l'aggiunta e' stata già inserita
                    switch (scelta_extra)
                    {
                        case "bacon":
                            if (!aggiunto_bacon)
                            {
                                piatto_generale = new ConBacon(piatto_generale!);
                                Console.WriteLine("Bacon aggiunto!");
                                aggiunto_bacon = true;
                            }
                            break;

                        case "formaggio":
                            if (!aggiunto_formaggio)
                            {
                                piatto_generale = new ConFormaggio(piatto_generale!);
                                Console.WriteLine("Formaggio aggiunto!");
                                aggiunto_formaggio = true;
                            }
                            break;
                        case "salsa":
                            if (!aggiunta_salsa)
                            {
                                piatto_generale = new ConSalsa(piatto_generale!);
                                Console.WriteLine("Salsa aggiunta!");
                                aggiunta_salsa = true;
                            }
                            break;
                        }
                }while(scelta_extra.ToLower() != "avanti");
                
                  
                            
                string cottura = InterfacciaUtente.MenuSceltaCottura(piatto_generale!);

                switch (cottura) //in base al tipo di cottura modifico la strategy gestita da Chef
                {
                    case "forno":
                        Chef.Instance.ImpostaStrategia(new AlForno());    //cottura al forno
                        break;
                    case "griglia":
                        Chef.Instance.ImpostaStrategia(new AllaGriglia());   //cottura alla griglia
                        break;
                    case "fritto":
                        Chef.Instance.ImpostaStrategia(new Fritto());  //cottura fritta
                        break;
                }

                Console.Clear();
                Console.WriteLine("\nNOTIFICA NEGOZI");
                Chef.Instance.PreparaPiatto(piatto_generale!);   //richiamo la classe singleton che gestisce lo strategy per avviare la preparazione con la cottura scelta

                char scelta; 
                do
                {   
                    Console.Write("\nVuoi cucinare ancora? (y/n): ");  //controllo per cucinare di nuovo
                    scelta = char.Parse(Console.ReadLine()!.ToLower());
                }while(scelta != 'y' && scelta != 'n');

                if(scelta == 'y')
                {
                    Console.Write("Perfetto...");
                    Console.ReadKey();                    
                }
                if(scelta == 'n')
                {
                    esci = true;
                    Console.Write("Arrivederci...");
                    Console.ReadKey();
                }    
                
            }
        }while(esci == false);
    }
}