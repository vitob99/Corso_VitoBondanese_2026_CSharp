using System;

class Program
{
    public static void Main(string[] args)
    {
        VoloAereo v = new VoloAereo();

        v.EffettuaPrenotazione(10);
        v.AnnullaPrenotazione(3);
        v.AnnullaPrenotazione(3);
        v.EffettuaPrenotazione(4);
        v.EffettuaPrenotazione(4);
        v.VisualizzaStato();

        Console.WriteLine("====================================");
        CompagniaVoli c = new CompagniaVoli();

        c.aggiungi(v);
        c.getVolo(v).VisualizzaStato();
        c.MostraVoli();
        c.CancellaVolo(v);
        
        

    }
}