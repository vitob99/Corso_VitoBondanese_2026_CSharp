using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        
        //ARRAY BIDIMENSIONALE
        int[,] numeri = new int[3, 3];
        numeri[0, 0] = 10;
        numeri[1, 2] = 20;
        int somma = numeri[0, 0] + numeri[1, 2];//risultato è 30
        
        int n_righe = numeri.GetLength(0);
        int n_colonne = numeri.GetLength(1);
        for(int i = 0; i < n_righe; i++)
        {
            for(int j = 0; j < n_colonne; j++)
            {
                numeri[i, j] = (i + j + 1) * 10;
                Console.WriteLine($"Matrice[{i},{j}] = {numeri[i, j]}");
            }
        }

        //ESPLORAZIONE DIAGONALE 1
        int somma_diagonale = 0;
        for(int i = 0; i < n_righe; i++)
        {
            for(int j = 0; j < n_colonne; j++)
            {
                if(i == j)
                {
                    somma_diagonale += numeri[i, j];
                }
            }
        }
        Console.WriteLine($"Somma Diagonale 1: {somma_diagonale}");

        //ESPLORAZIONE DIAGONALE 2
        int somma_diagonale_due = 0;
        for(int i = 0; i < n_righe; i++)
        {
            for(int j = 0; j < n_colonne; j++)
            {
                if(i == j)
                {
                    somma_diagonale_due += numeri[i, n_colonne - 1 - i];
                    
                }
            }
        }
        Console.WriteLine($"Somma Diagonale 2: {somma_diagonale_due}");

        //ESPLORAZIONE AL CONTRARIO
        for(int i = n_righe - 1; i >= 0; i--)
        {
            for(int j = n_colonne - 1; j >= 0; j--)
            {
                
            }
        }
        //RIEMPIRE MATRICE CON NUMERI CASUALI DA 0 A 500
        int[,] matrice = new int[10, 10];
        int n_righe_matrice = matrice.GetLength(0);
        int n_colonne_matrice = matrice.GetLength(1);
        Random random = new Random();
        for(int i = 0; i < n_righe_matrice; i++)
        {
            for(int j = 0; j < n_colonne_matrice; j++)
            {
                matrice[i, j] = random.Next(501); //random.Next(100, 150)
                //double numeroDecimale = random.NextDouble() * (15 - 5) + 5; // ... * (max - min) + min
                Console.WriteLine($"Matrice[{i},{j}] = {matrice[i, j]}");
            }
        }



        //ESERCIZI RANDOM
        Console.WriteLine("--------------------ESERCIZI RANDOM --------------------------------------");
        /*
            1.Scrivere un programma che genera un numero casuale tra 1 e 10 e chiedere all’utente
            di indovinarlo.
        */
            Random r = new Random();
            int random_int = r.Next(1, 10);
            Console.WriteLine($"E' stato generato un numero casuale tra 1 e 10! Indovinalo! {random_int}");
            int scelta_int;
            do
            {
                Console.Write("Indovina: ");
                scelta_int = int.Parse(Console.ReadLine());
            }while(scelta_int != random_int);
            Console.WriteLine("Indovinato!");



        /*
            2.Simula il lancio di due dadi a 6 facce e comunica all’utente il risultato e la somma.
        */
            int dado1 = r.Next(1, 6);
            Console.WriteLine($"Dado 1: {dado1}");
            int dado2 = r.Next(1, 6);
            Console.WriteLine($"Dado 2: {dado2}");
            Console.WriteLine($"Somma dadi: {dado1 + dado2}");
        /*
            3.L’utente inserisce il numero di giorni da simulare. Per ogni giorno viene generata una temperatura casuale tra minTemp e maxTemp (valori fissi nel codice).
            a.Al termine, vengono mostrate:
                i.Tutte le temperature
                ii.La temperatura minima
                iii.La temperatura massima
                iv.La temperatura media
        */
            double minTemp = 5;
            double maxTemp = 30;

            double[] temperature;

            double min = double.MaxValue;
            double max = double.MinValue;
            double somma_temperature = 0;

            double temp;
            int n_giorni;
            Console.Write("Inserisci il numero di giorni da simulare: ");
            n_giorni = int.Parse(Console.ReadLine());
            temperature = new double[n_giorni];
            for(int i = 0; i < n_giorni; i++)
            {
                temp = r.NextDouble() * (maxTemp - minTemp) + minTemp;
                temperature[i] = temp;
                somma_temperature += temp;
                if(temp < min)
                {
                    min = temp;
                }

                if(temp > max)
                {
                    max = temp;
                }
            }
            
            Console.WriteLine("Lista temperature: ");
            foreach(double t in temperature)
            {
                Console.WriteLine($"{t:F2}°");
            }
            Console.WriteLine($"Temperatura minima: {min:F2}°");
            Console.WriteLine($"Temperatura massima: {max:F2}°");
            Console.WriteLine($"Temperatura media: {(somma_temperature / n_giorni):F2}°");



        Console.WriteLine("--------------------ESERCIZI MATRICI---------------------------------------");
        //ESERCIZI MATRICI

        /*
            1. Scrivi un programma che:
                a.Chiede all’utente le dimensioni di una matrice (righe e colonne).
                b.Fa inserire i valori riga per riga.
                c.Calcola e stampa la somma di tutti gli elementi, delle singole righe e delle singole colonne.
        */
        int n_righe_input;
        int n_colonne_input;
        Console.Write("Righe: ");
        n_righe_input = int.Parse(Console.ReadLine());
        Console.Write("Colonne: ");
        n_colonne_input = int.Parse(Console.ReadLine());
        int[,] mat = new int[n_righe_input, n_colonne_input];


        int somma_riga;
        for(int i = 0; i < n_righe_input; i++)
        {
            somma_riga = 0; 
            for(int j = 0; j < n_colonne_input; j++)
            {
                Console.Write($"Inscerisci nella posizione [{i}, {j}]: ");
                int valore = int.Parse(Console.ReadLine());
                mat[i, j] = valore;
                somma_riga += valore;      
            }  
            Console.WriteLine($"Somma riga {i + 1} = {somma_riga}");       //SOMMA SINGOLA RIGA
        }

        //SOMMA DELLE COLONNE
        int somma_colonna;
        for (int j = 0; j < n_colonne_input; j++) 
        {
            somma_colonna = 0;
            for (int i = 0; i < n_righe_input; i++) 
            {
                somma_colonna += mat[i, j];
            }
            Console.WriteLine($"Somma colonna {j + 1} = {somma_colonna}");
        }

        /*
            2.Scrivi un programma che:
                a.Genera 2 matrici 4x4 con numeri casuali compresi tra 1 e 50.
                b.Stampa la matrice in forma tabellare.
                c.Calcola e stampa la somma degli elementi di ogni riga.
                d.Confronta la somma di ogni riga tra le 2 matrici e calcola quali delle 2 matrici ha più righe che vincono il confronto o se pareggiano.
        */

        //GENERO E STAMPO 2 MATRICI 4X4 CON NUMERI CASUALI TRA 1 E 50
        Random r_mat = new Random();
        const int RIGHE = 4;
        const int COLONNE  = 4;
        int[,] mat1 = new int[RIGHE, COLONNE];
        int[,] mat2 = new int[RIGHE, COLONNE];

        Console.WriteLine();
        Console.Write("MATRICE 1");
        for(int i = 0; i < RIGHE; i++)
        {   
            Console.WriteLine();
            for(int j = 0; j < COLONNE; j++)
            {
                mat1[i, j] = r_mat.Next(1, 50);
                Console.Write($"{mat1[i, j]}  \t");
            }    
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("MATRICE 2");
        for(int i = 0; i < RIGHE; i++)
        {   
            Console.WriteLine();
            for(int j = 0; j < COLONNE; j++)
            {
                mat2[i, j] = r_mat.Next(1, 50);
                Console.Write($"{mat2[i, j]}   \t");
            }    
        }        
        Console.WriteLine();
        Console.WriteLine();

        //SOMMA RIGA PER RIGA DELLA MATRICE1 E DELLA MATRICE2
        Console.WriteLine("MATRICE 1 - SOMMA RIGHE");
        int[] vett_somme_mat1 = new int[RIGHE]; //VETTORE SOMME RIGHE MAT1
        int somma_riga_mat1 = 0;
        for(int i = 0; i < RIGHE; i++)
        {
            for(int j = 0; j < COLONNE; j++)
            {
                somma_riga_mat1 += mat1[i, j];     
            }     
            Console.WriteLine($"Somma riga {i + 1} = {somma_riga_mat1}");  
            vett_somme_mat1[i] = somma_riga_mat1; 
            somma_riga_mat1 = 0;   
        }

        Console.WriteLine();
        Console.WriteLine("MATRICE 2 - SOMMA RIGHE");
        int[] vett_somme_mat2 = new int[RIGHE];  //VETTORE SOMME RIGHE MAT2
        int somma_riga_mat2 = 0;
        for(int i = 0; i < RIGHE; i++)
        {
            for(int j = 0; j < COLONNE; j++)
            {
                somma_riga_mat2 += mat2[i, j];     
            }  
            Console.WriteLine($"Somma riga {i + 1} = {somma_riga_mat2}");
            vett_somme_mat2[i] = somma_riga_mat2;        
            somma_riga_mat2 = 0;   
        }
    
        //CALCOLO PUNTEGGIO
        int punti_mat1 = 0;
        int punti_mat2 = 0;
        for(int i = 0; i < vett_somme_mat1.Length; i++)
        {
            if(vett_somme_mat1[i] > vett_somme_mat2[i])
            {
                punti_mat1++;
            }
            else if(vett_somme_mat1[i] < vett_somme_mat2[i])
            {
                punti_mat2++;
            }
        }
        //CONFRONTO
        if(punti_mat1 > punti_mat2)
        {
            Console.WriteLine($"Vince MATRICE1 con {punti_mat1} punti contro i {punti_mat2} punti di MATRICE2!");
        }
        else if(punti_mat1 < punti_mat2)
        {
            Console.WriteLine($"Vince MATRICE2 con {punti_mat2} punti contro i {punti_mat1} punti di MATRICE1!");
        }
        else
        {
            Console.WriteLine($"PAREGGIO, entrambe {punti_mat1} punti!");
        }



        /*
            3.Scrivi un programma che:
                a.Genera una matrice quadrata 5x5 con numeri casuali compresi tra 1 e 20.
                b.Stampa la matrice.
                c.Calcola e stampa la somma della diagonale principale e della diagonale secondaria.
                d.Indica quale delle due somme è maggiore.
        */    

        //GENERO LA MATRICE 5X5 CON NUMERI CASUALI TRA 1 E 20
        const int RIGHE5 = 5;
        const int COLONNE5 = 5;
        int[,] mat5 = new int[RIGHE5, COLONNE5];

        for(int i = 0; i < RIGHE5; i++)
        {
            for(int j = 0; j < COLONNE5; j++)
            {
                 mat5[i, j] = random.Next(1, 20);
            }           
        }

        //STAMPO LA MATRICE 5X5
        Console.WriteLine();
        Console.Write("MATRICE 5x5");
        for(int i = 0; i < RIGHE5; i++)
        {   
            Console.WriteLine();
            for(int j = 0; j < COLONNE5; j++)
            {
                Console.Write($"{mat5[i, j]}  \t");
            }    
        }     

        //SOMMA DIAGONALE PRINCIPALE
        int somma_diagonale_principale = 0;
        for(int i = 0; i < RIGHE5; i++)
        {   
            for(int j = 0; j < COLONNE5; j++)
            {
                if(i == j)
                {
                    somma_diagonale_principale += mat5[i, j];
                }
            }    
        }
        
        //SOMMA DIAGONALE SECONDARIA
        int somma_diagonale_secondaria = 0;
        for (int i = 0; i < RIGHE5; i++)
        {
            somma_diagonale_secondaria += mat5[i, RIGHE5 - 1 - i];
        }

        //CONFRONTO
        Console.WriteLine();
        if(somma_diagonale_principale > somma_diagonale_secondaria)
        {
            Console.WriteLine($"La somma della diagonale secondaria {somma_diagonale_principale} e' maggiore di quella della diagonale principale {somma_diagonale_secondaria}");
        }
        else if(somma_diagonale_principale < somma_diagonale_secondaria)
        {
            Console.WriteLine($"La somma della diagonale secondaria {somma_diagonale_secondaria} e' maggiore di quella della diagonale principale {somma_diagonale_principale}");
        }
        else
        {
            Console.WriteLine($"Entrambe le somme delle diagonali corrispondono a {somma_diagonale_principale}!");
        }
    }
}