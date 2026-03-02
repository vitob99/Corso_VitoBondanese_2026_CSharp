class Test
{
    private int x;
    private int y;

    public Test()
    {
        x = 5;
        y = 10;
    }

    public override string ToString()
    {
        return $"I due numeri sono {x} e {y}";
    }

    public override bool Equals(object? obj)
    {
        if(obj is Test obj2)
        {
            return this.x == obj2.x && this.y == obj2.y;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(x, y);
    }
    
}