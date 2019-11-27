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
    }
}
