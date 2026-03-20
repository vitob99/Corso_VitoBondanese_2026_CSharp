using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class MagazzinoContext : DbContext
{
    private DbSet<Prodotto> prodotti => Set<Prodotto>();
    
    public DbSet<Prodotto> Prodotti
    {
        get{return prodotti;}
    }

    // Connection string centrale (adatta server/credenziali al tuo ambiente)
    private const string ConnString ="server=localhost;port=3306;user=root;password=passwordsql;database=rubrica_db";
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseMySql(ConnString, ServerVersion.AutoDetect(ConnString));
}
