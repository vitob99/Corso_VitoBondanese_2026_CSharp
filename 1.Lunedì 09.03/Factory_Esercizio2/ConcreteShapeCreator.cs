class ConcreteShapeCreator : ShapeCreator
{
    public override IShape CreateShape(int type)
    {
        switch (type)
        {
            case 2: //triangolo
                return new Triangle();
            case 3: //rettangolo
                return new Rectangle();
            case 4:  ///quadrato
                return new Square();      
            default:
                throw new Exception("Forma non valida");          
        }
    }
}