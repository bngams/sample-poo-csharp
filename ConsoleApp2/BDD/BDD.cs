using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class BDD
    {
        // on peut stocker les paramètres dans des variables
        // voir des fichiers de conf
        string dbHost = "localhost";

        public static MySqlConnection getMySqlConnection()
        {
            string connStr = "server=localhost;user=root;database=poo;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            return conn;
        }
    }
}
