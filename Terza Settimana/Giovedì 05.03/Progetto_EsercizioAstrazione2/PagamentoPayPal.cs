class PagamentoPayPal : MetodoDiPagamentoBase
{   
    private string email_utente;
    public string EmailUtente
    {
        get { return email_utente; }
        set
        {
            if (value != null && value.Contains('@'))
            {
                email_utente = value;
            }
            else
            {
                email_utente = "Errore mail";
            }
        }
    }
        
    public PagamentoPayPal(string email) : base("PayPal")
    {
        EmailUtente = email;
    }

    public override void EseguiPagamento(decimal importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da: {email_utente}");
    }

    public override void MostraMetodo()
    {
        Console.WriteLine($"Metodo: PayPal");
    }
}