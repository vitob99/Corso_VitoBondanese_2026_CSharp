class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine($"Disegna un {GetType().Name}!");
    }
}