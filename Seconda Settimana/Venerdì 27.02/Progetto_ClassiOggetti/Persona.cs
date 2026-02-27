using System;

class Persona
{
    public string nome;
    public int eta;

    public Persona()
    {
        nome = "Nome Default";
        eta = 0;
    }

    public Persona(string nome, int eta)
    {
        this.nome = nome;
        this.eta = eta;
    }

    public void Presentati()
    {
        Console.WriteLine($"Ciao sono {nome} e ho {eta} anni!");
    }
}