using System;

class Program
{
    public static void Main(string[] args)
    {
  
        PrenotazioneViaggio p = new PrenotazioneViaggio("Las Vegas");


        p.PrenotaPosti(10); //10 occupati 10 disponibili
        p.PrenotaPosti(11); //non aggiorna lo stato di p
        p.AnnullaPrenotazione(5); //5 occupati 15 disponibili
        p.AnnullaPrenotazione(2); //3 occupati 17 disponibili
        p.AnnullaPrenotazione(3); //0 occupati 20 disponibili
        p.PrenotaPosti(7); //7 occupati e 13 disponibili
        Console.WriteLine(p);


    }
}