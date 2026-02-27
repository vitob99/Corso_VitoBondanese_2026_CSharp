class Cane
{
    public string nome;


    public Cane()
    {
        nome = "Nome Cane Default";
    }
    public Cane(string nome)
    {
        this.nome = nome;
    }
    public void Abbaia()
    {
        Console.WriteLine($"Il cane {nome} abbaia!");
    }
}