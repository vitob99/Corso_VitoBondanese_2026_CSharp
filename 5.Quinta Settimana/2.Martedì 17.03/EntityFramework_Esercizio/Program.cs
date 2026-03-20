using System;

class Program
{
    public static void Main(string[] args)
    {
        using var db = new MagazzinoContext();
        db.Database.EnsureCreated();

        //CREATE
        var nuovo = new Prodotto { Nome_Prodotto = "Spazzolino", Prezzo = 1.5f};
        db.Prodotti.Add(nuovo);
        db.SaveChanges();
        Console.WriteLine($"Creato prodotto Id = {nuovo.Id}");

        //READ
        var prodotti_economici = db.Prodotti.Where(prod => prod.Prezzo < 50f).ToList();
        Console.WriteLine("Prodotti che costano meno di 50$: ");
        foreach (var p in prodotti_economici)
        {
            Console.WriteLine($"{p.Id} - {p.Nome_Prodotto} => {p.Prezzo}$");
        }
        
        //UPDATE
        Prodotto? prodottoDaAggiornare = db.Prodotti.FirstOrDefault(p => p.Nome_Prodotto == "Microfono USB"); //trovo il prodotto

        if (prodottoDaAggiornare != null) //se lo trovo...
        {
            prodottoDaAggiornare.Prezzo = 30.5f;
            db.SaveChanges();
            Console.WriteLine($"Prezzo aggiornato per: {prodottoDaAggiornare.Nome_Prodotto}. Nuovo prezzo: {prodottoDaAggiornare.Prezzo}$");
        }
        else
        {
            Console.WriteLine($"Prodotto non trovato!");
        }
    }
}
