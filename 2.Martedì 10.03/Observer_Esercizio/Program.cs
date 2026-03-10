using System;

class Program
{
    private enum Clima{Pioggia, Neve, Grandine, Sole, Vento};

    public static void Main(string[] args)
    {
        CentroMeteo centro = new CentroMeteo();
        centro.Registra(new DisplayConsole());   //aggiungo gli osservatori (due display) per il CentroMeteo
        centro.Registra(new DisplayMobile());
        

        
        bool esci = false;
        do
        {
            Clima meteo;
            Console.Write("Dati meteo: ");
            if(Enum.TryParse(Console.ReadLine(), out meteo))
            {
                switch (meteo)
                {
                case Clima.Grandine:
                    centro.AggiornaMeteo(meteo.ToString()); //il metodo va ad aggiornare lo stato di CentroMeteo
                    break;
                case Clima.Pioggia:
                    centro.AggiornaMeteo(meteo.ToString());
                    break;
                case Clima.Sole:
                    centro.AggiornaMeteo(meteo.ToString());
                    break;
                case Clima.Vento:
                    centro.AggiornaMeteo(meteo.ToString());
                    break;
                case Clima.Neve:
                    centro.AggiornaMeteo(meteo.ToString());
                    break;
                }
            }
            else
            {
                Console.WriteLine("Clima non valivo");
                esci = true;
            }

        }while(esci == false);
        
        


    }
}