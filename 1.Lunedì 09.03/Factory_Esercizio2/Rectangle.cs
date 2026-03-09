class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Sto disegnando un {GetType().Name}!");
    }
}