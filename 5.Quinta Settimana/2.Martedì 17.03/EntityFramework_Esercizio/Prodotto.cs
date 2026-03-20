using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("prodotti")]  //definisco il modello che collego alla tabella "Studenti" del db
public class Prodotto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
    public int Id { get; set; }

    [Required] //NOT NULL
    [MaxLength(50)]  //lunghezza massima del campo, la stessa che ho nel DB
    [Column("nome")] //collego l'attributo alla colonna "nome" del DB
    public string Nome_Prodotto { get; set; } = default!;

    [Required] //NOT NULL
    [Column("prezzo")] //collego l'attributo alla colonna "prezzo" del DB
    public float Prezzo { get; set; } = default!;
}