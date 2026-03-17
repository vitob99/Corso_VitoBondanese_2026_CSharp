using System;

// Client
public class Program
{
    public static void Main()
    {
        // Creazione dei singoli sottosistemi
        TV tv = new TV();
        AudioSystem audio = new AudioSystem();
        Lights lights = new Lights();

        // Creazione della facade
        HomeTheaterFacade homeTheater = new HomeTheaterFacade(tv, audio, lights);

        // Il client usa solo la facade
        homeTheater.WatchMovie();

        Console.WriteLine();

        homeTheater.EndMovie();
    }
}