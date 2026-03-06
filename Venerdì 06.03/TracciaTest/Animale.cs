abstract class Animale
{
    string? nome;
    int eta;
    double peso;
    public string Nome
    {
        get{
            if(nome != null)
            {
                return nome;
            }
            else
            {
                return "Animale senza nome";
            }
        }
        set{nome = value;}
    }
    public int Eta
    {
        get{return eta;}
        set
        {
            if(value > 0)
            {
                eta = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }
    public double Peso
    {
        get{return peso;}
        set
        {
            if(value > 0)
            {
                peso = value;
            }
            else
            {
                throw new Exception();
            }
        }
    }

    public Animale(string nome, int eta, double peso)
    {
        Nome = nome;
        Eta = eta;
        Peso = peso;
    }

    public abstract void EmettiVerso();
    public abstract void Salta();
    public abstract void Mangia();
    public abstract void Gioca();

    public virtual void InfoAnimale()
    {
        Console.WriteLine($"Nome: {Nome}\nEta: {Eta}\nPeso: {Peso}");
    }
}