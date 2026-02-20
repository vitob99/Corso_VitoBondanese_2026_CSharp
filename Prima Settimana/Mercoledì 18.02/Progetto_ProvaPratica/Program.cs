using System;

class Program{
    public static void Main(string[] args)
    {
        string nome_utente = "defaultUser";  //nome utente
        string password = "defaultPassword"; //password
        bool ripeti = true; //flag ripetizione menù principale
        do
        {
            Console.WriteLine("1.Accedi");
            Console.WriteLine("2.Registrati");
            Console.WriteLine("3.Esci");
            Console.Write("Scelta: ");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: //CASO ACCEDI
                    bool riprova = true; 
                    while(riprova == true)
                    {
                        Console.Write("Inserisci il nome utente: ");
                        string nome_utente_inserito = Console.ReadLine();
                        Console.Write("Inserisci la password: ");
                        string password_inserita = Console.ReadLine();
                        if(nome_utente_inserito == nome_utente && password_inserita == password)
                        {
                            //CREDENZIALI CORRETTE
                            Console.WriteLine($"Accesso consentito! Benvenuto {nome_utente_inserito}!");


                            bool ripeti_countdown = true;
                            do
                            {
                                Console.Write("Inserisci un numero da cui fare il countdown: ");
                                int numero_countdown = int.Parse(Console.ReadLine());
                                Console.WriteLine("CountDown: ");
                                for(int i = numero_countdown; i >= 0; i--)
                                {
                                    Console.WriteLine(i);
                                }
                                Console.WriteLine("Vuoi rifare il countdown con un nuovo numero?");
                                Console.WriteLine("1. SI");
                                Console.WriteLine("2. NO");
                                Console.Write("Scelta: ");
                                int scelta_countdown = int.Parse(Console.ReadLine());
                                switch (scelta_countdown)
                                {
                                    case 1:
                                        break;
                                    case 2:
                                        ripeti_countdown = false;
                                        riprova = false;
                                        break;
                                    default:
                                        Console.WriteLine("Scelta non valida!");
                                        break;                                        
                                }                              
                            }while(ripeti_countdown == true);
                        }
                        else
                        {
                            //CREDENZIALI SBAGLIATE
                            Console.WriteLine("Le credenziali inserite sono errate!");
                            int scelta_riprova;
                            do{
                                Console.WriteLine("Vuoi riprovare?");
                                Console.WriteLine("1. SI");
                                Console.WriteLine("2. NO");
                                Console.Write("Scelta: ");
                                scelta_riprova = int.Parse(Console.ReadLine());
                                switch (scelta_riprova)
                                {
                                    case 1: //SE VOGLIO RIPROVARE IL FLAG 'riprova' NON CAMBIA
                                        break;
                                    case 2:  //SE NON VOGLIO RIPROVARE...
                                        riprova = false;
                                        break;
                                    default: //SE LA SCELTA NON E' VALIDA
                                        Console.WriteLine("Scelta non valida");
                                        break;
                                }
                                
                            }while(scelta_riprova != 1 && scelta_riprova != 2);
                        }                        
                    }

                    break;


                case 2: ///CASO REGISTRATI
                    Console.Write("Inscerisci un nome utente: ");
                    nome_utente = Console.ReadLine();
                    Console.Write("Inscerisci un nome utente: ");
                    password = Console.ReadLine();
                    Console.WriteLine("Utente Registrato con successo!");
                    break;   
                case 3:  //CASO ESCI
                    ripeti = false;
                    break;
                default:  //SCELTA NON VALIDA
                    Console.WriteLine("Scelta non valida!");
                    break;
        }  
        }while(ripeti == true);

    }
}