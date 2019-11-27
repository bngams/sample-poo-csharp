using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class VoitureBDD
    {
        public List<Voiture> SelectAll()
        {
            // simule appel bdd et renvoi d'une liste
            // creation de l'bojet => instanciation
            Voiture v1 = new Voiture(200, EMarque.Peugeot);
            Voiture v2 = new Voiture(180, EMarque.Tesla);

            List<Voiture> voitures = new List<Voiture>();
            voitures.Add(v1);
            voitures.Add(v2);

            return voitures;
        }

        public static List<Voiture> SelectAllStatique()
        {
            // simule appel bdd et renvoi d'une liste
            // creation de l'bojet => instanciation
            Voiture v1 = new Voiture(200, EMarque.Peugeot);
            Voiture v2 = new Voiture(180, EMarque.Tesla);

            List<Voiture> voitures = new List<Voiture>();
            voitures.Add(v1);
            voitures.Add(v2);

            return voitures;
        }

        public static List<Voiture> SelectAllBDD()
        {
            MySqlConnection conn = BDD.getMySqlConnection();
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                // la redaction de la requete
                string sql = "SELECT * FROM voiture;";
                // l'execution  de la requete avec les classes mysql (avec les classes du driver)
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                // executer la requete et recupérer le resultat
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Voiture> voitures = new List<Voiture>();
                Console.WriteLine("Lecture des résultats...");
                // lire chaque ligne de resultat
                // trnasforme ma ligne en objet
                // je stocke l'objet dans ma liste 
                while (rdr.Read())
                {
                    // pour chaque ligne on affiche les différentes colonnes
                    Console.WriteLine(rdr[0] + " | " + rdr[1] + " | " + rdr[2]);
                    // traduction en int
                    Voiture v = new Voiture(int.Parse(rdr[1].ToString()), EMarque.Peugeot);
                    voitures.Add(v);
                }
                // fin de la lecture
                rdr.Close();

                return voitures;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // on ferme la connexion
            conn.Close();
            return null;
        }
    }
}
