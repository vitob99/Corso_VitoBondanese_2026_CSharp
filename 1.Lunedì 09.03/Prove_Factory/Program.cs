using System;

class Program
{
    public static void Main(string[] args)
    {
        Creator creatorA = new ConcreteCreatorA();
        creatorA.AnOperation(); // Usa ConcreteProductA

        Creator creatorB = new ConcreteCreatorB();
        creatorB.AnOperation(); // Usa ConcreteProductB
    }
}