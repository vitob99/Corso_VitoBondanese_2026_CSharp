using System.Security.Cryptography.X509Certificates;

class Corso
{
    public string nome_corso;
    public int durata_ore;
    public string docente;
    public List<string> studenti;


    public Corso(string nome_corso, int durata_ore, string docente)
    {
        this.nome_corso = nome_corso;
        this.durata_ore = durata_ore;
        this.docente = docente;
        studenti = new List<string>();
    }
    
    public void AggiungiStudente(string nomeStudente)
    {
        studenti.Add(nomeStudente);
    }

    public override string ToString()
    {
        return $"Nome Corso: {nome_corso}\nDurate Ore: {durata_ore}\nDocente: {docente}\n";
    }

    public virtual void MetodoSpeciale(){
        Console.WriteLine("Corso generico");
    }
    

}