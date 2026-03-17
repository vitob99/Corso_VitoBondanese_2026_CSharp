using MySql.Data.MySqlClient;
class MySqlOperations
{
    public static void AggiungiContatto(string nome_contatto, string telefono_contatto)
    {
        try
        {
            MySqlConnection connessione_sql = MySqlSingleton.ConnessioneSqlInstance;
            connessione_sql.Open();
            string query = $"INSERT INTO contatti (nome, telefono) VALUES ('{nome_contatto}','{telefono_contatto}')";
            MySqlCommand cmd = new MySqlCommand(query, connessione_sql);
            cmd.ExecuteNonQuery(); 
            Console.WriteLine($"Il contatto '{nome_contatto}' con telefono '{telefono_contatto}' e' stato aggiunto con successo!");
            connessione_sql.Close();

        }
        catch (MySqlException)
        {
            Console.WriteLine("Errore MySQL durante l'aggiunta del contatto!");
        }
        Console.Write("Premi un tasto per continuare...");
        Console.ReadKey();   
    }

    public static void ListaContatti() 
    {
        try
        {
            string query = "SELECT id, nome, telefono FROM contatti";
            MySqlConnection connessione_sql = MySqlSingleton.ConnessioneSqlInstance;
            connessione_sql.Open();
            MySqlCommand cmd = new MySqlCommand(query, connessione_sql);
            MySqlDataReader reader = cmd.ExecuteReader();

            Console.Clear();
            if (reader.HasRows)
            {
                Console.WriteLine("LISTA CONTATTI");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Telefono: {reader["telefono"]}");
                }
            }
            else
            {
                Console.WriteLine("La rubrica e' vuota!");
            }
            connessione_sql.Close();          
        }
        catch (MySqlException)
        {
            Console.WriteLine("Errore di MySql durante la visualizzazione dei contatti!");
        }
        Console.Write("Premi un tasto per continuare...");
        Console.ReadKey();   
    }

    public static void EliminaContatto(string nome_contatto)
    {
        try
        {
            string query = $"DELETE FROM contatti WHERE nome='{nome_contatto}'";
            MySqlConnection connessione_sql = MySqlSingleton.ConnessioneSqlInstance;
            connessione_sql.Open();
            MySqlCommand cmd = new MySqlCommand(query, connessione_sql);

            int rows = cmd.ExecuteNonQuery();
            if(rows == 0)
            {
                Console.WriteLine($"Il contatto inserito '{nome_contatto}' non e' stato trovato!");
            }
            else
            {
                Console.WriteLine($"Il contatto '{nome_contatto}' e' stato eliminato con successo!");
            }
            connessione_sql.Close();
        }
        catch (MySqlException)
        {
            Console.WriteLine($"Errore di MySql durante la cancellazione del contatto '{nome_contatto}'");
        }
        Console.Write("Premi un tasto per continuare...");
        Console.ReadKey(); 
    }
}