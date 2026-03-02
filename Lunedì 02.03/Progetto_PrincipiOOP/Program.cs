using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // --- Parte iniziale del tuo codice ---
        Test t = new Test();
        Test t2 = new Test();
        Console.WriteLine(t); 
        Console.WriteLine(t.Equals(t2));

        Libro l1 = new Libro("Atomic Habits","James Clear", 2023);
        Libro l2 = new Libro("AI Engineering","Chip Huyen", 2024);
        Libro l3 = new Libro("AI Engineering","Chip Huyen", 2024);

        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);

        Console.WriteLine($"l1 uguale a l2 = {l1.Equals(l2)}");
        Console.WriteLine($"l2 uguale a l3 = {l2.Equals(l3)}");
        Console.WriteLine($"l1 hashcode = {l1.GetHashCode()}");
        Console.WriteLine($"l2 hashcode = {l2.GetHashCode()}");
        Console.WriteLine($"l3 hashcode = {l3.GetHashCode()}");

        Console.WriteLine($"tipo 'l1' = {l1.GetType()}");
        Console.WriteLine($"tipo 't' = {t.GetType()}");

        Console.WriteLine(Object.ReferenceEquals(l1, l2));
        l1 = l2;
        Console.WriteLine(Object.ReferenceEquals(l1, l2));

        Libro l4 = l3.copia();
        Console.WriteLine($"l4 = {l4}");

        // 
        Utente u_aggiunto = new Utente("Mario", 10);
        Dictionary<Utente, List<Macchina>> garage = new Dictionary<Utente, List<Macchina>>();
        garage.Add(u_aggiunto, new List<Macchina>());

        garage[u_aggiunto].Add(new Macchina());
        garage[u_aggiunto].Add(new Macchina());
        garage[u_aggiunto].Add(new Macchina());



        Utente utente_login;
        int crediti_utente;
        string nome_utente;
        bool login = false;
        do
        {
            Console.Clear();
            Console.Write("Nome utente: ");
            nome_utente = Console.ReadLine()!;
            Console.Write("Crediti: ");
            crediti_utente = int.Parse(Console.ReadLine()!);

            utente_login = new Utente(nome_utente, crediti_utente);
            foreach (var coppia in garage)
            {
                if (coppia.Key.Equals(utente_login))
                {
                    login = true;
                }
            }
        } while (login == false);

        int numero_auto_utente_login = garage[utente_login].Count;
        int scelta_auto;
        Macchina auto_modifica; 
        if (numero_auto_utente_login == 0)
        {
            Console.WriteLine("L'utente non possiede auto!");
            Console.WriteLine("Premi un tasto per continuare...");
            Console.ReadKey();
            return; 
        }
        else
        {
            do
            {
                Console.WriteLine($"Lista auto => {utente_login.nome}: ");
                for (int i = 0; i < numero_auto_utente_login; i++)
                {
                    Console.WriteLine($"[{i + 1}] {garage[utente_login][i]}");
                }
                Console.WriteLine();
                Console.Write("Scegli l'auto da modificare: ");
                scelta_auto = int.Parse(Console.ReadLine()!);

            } while (scelta_auto > numero_auto_utente_login || scelta_auto <= 0);

            auto_modifica = garage[utente_login][scelta_auto - 1];
        }

        int scelta;
        bool esci = false;
        do
        {
            if (crediti_utente > 0)
            {
                Console.Clear();
                Console.WriteLine($"MENU' MODIFICA => Crediti disponibili: {crediti_utente}");
                Console.WriteLine();
                Console.WriteLine($"[1] Aumento della velocità di 10 - Costo: {Macchina.COSTO_VELOCITA}");
                Console.WriteLine($"[2] Cambia del tipo del motore - Costo: {Macchina.COSTO_MOTORE}");
                Console.WriteLine($"[3] Aumento di 1 nelle sospensioni - Costo: {Macchina.COSTO_SOSPENSIONI}");
                Console.WriteLine("[4] Esci");
                Console.Write("Scelta: ");
                scelta = int.Parse(Console.ReadLine()!);
                switch (scelta)
                {
                    case 1:
                        if (crediti_utente >= Macchina.COSTO_VELOCITA)
                        {
                            crediti_utente -= Macchina.COSTO_VELOCITA;
                            auto_modifica.velocita_max += 10;
                            auto_modifica.nr_modifiche++;
                            Console.WriteLine($"Velocita' incrementata con successo => {auto_modifica.velocita_max}");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Non hai crediti sufficienti per questa modifica!");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (crediti_utente >= Macchina.COSTO_MOTORE)
                        {
                            string new_nome_motore;
                            crediti_utente -= Macchina.COSTO_MOTORE;
                            Console.Write("Nome motore: ");
                            new_nome_motore = Console.ReadLine()!;

                            auto_modifica.motore = new_nome_motore;
                            auto_modifica.nr_modifiche++;
                            Console.WriteLine($"Nome motore cambiato in => {new_nome_motore}");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Non hai crediti sufficienti per questa modifica!");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (crediti_utente >= Macchina.COSTO_SOSPENSIONI)
                        {
                            crediti_utente -= Macchina.COSTO_SOSPENSIONI;

                            auto_modifica.sospensioni_max++;
                            auto_modifica.nr_modifiche++;
                            Console.WriteLine($"(+1) Le sospensioni sono state inscrementate => {auto_modifica.sospensioni_max}");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Non hai crediti sufficienti per questa modifica!");
                            Console.WriteLine("Premi un tasto per continuare...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        esci = true;
                        break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Hai esaurito il credito!");
                Console.WriteLine();
                esci = true;
            }

        } while (esci == false);

        Console.WriteLine($"Auto '{auto_modifica.motore}' aggiornata!");
        Console.WriteLine(auto_modifica);
    }
}