using System;
using MySql.Data.MySqlClient;

class MySqlSingleton
{
    private static MySqlConnection? mysql_conn;

    private const string CONN_STRING = "server=localhost;user=root;password=passwordsql;database=rubrica_db";

    public static MySqlConnection ConnessioneSqlInstance
    {
        get
        {
            if(mysql_conn == null)
            {
                mysql_conn = new MySqlConnection(CONN_STRING);
            } 
            return mysql_conn;
        }
    }
}