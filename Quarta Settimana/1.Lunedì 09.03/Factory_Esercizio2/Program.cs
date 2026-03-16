class Progrsm
{
    private static int Menu()
    {
        Console.Clear();
        Console.WriteLine("[1] Disegna un cerchio");
        Console.WriteLine("[2] Disegna un triangolo");
        Console.WriteLine("[3] Disegna un rettangolo");
        Console.WriteLine("[4] Disegna un quadrato");
        Console.WriteLine("[5] Esci");
        Console.Write("Scelta:");
        return int.Parse(Console.ReadLine()!);
    }

    public static void Main(string[] args)
    {
        ShapeCreator creator = new ConcreteShapeCreator();
        CircleCreator creator2 = new CircleCreator();
        bool esci = false;
        int scelta;
        do
        {
            scelta = Menu();

            try
            {
                switch (scelta)
                {
                    case 1: //crea cerchio
                        Console.Clear();
                        IShape cerchio = creator2.CreateShape(1);
                        cerchio.Draw();

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                    case 2: //crea triangolo
                        Console.Clear();
                        IShape triangolo = creator.CreateShape(2);
                        triangolo.Draw();

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                    case 3: //crea rettangolo
                        Console.Clear();
                        IShape rettangolo = creator.CreateShape(3);
                        rettangolo.Draw();

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                    case 4:   //crea quadrato
                        Console.Clear();
                        IShape quadrato = creator.CreateShape(4);
                        quadrato.Draw();

                        Console.Write("Premi un tasto per continuare...");
                        Console.ReadKey();
                        break;
                    case 5:
                        esci = true;
                        break;
                }                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }while(esci == false);
    }
}