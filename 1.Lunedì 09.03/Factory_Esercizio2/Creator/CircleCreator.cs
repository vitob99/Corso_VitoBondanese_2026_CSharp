class CircleCreator : ShapeCreator
{
    public override IShape CreateShape(int type)
    {
        if (type == 1)
        {
            return new Circle();            
        }
        throw new Exception("Errore");
    }
}