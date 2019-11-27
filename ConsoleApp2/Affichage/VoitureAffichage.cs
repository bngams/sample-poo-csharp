using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class VoitureAffichage
    {
        public static void Affiche()
        {
            List<Voiture> voitures;

            // appel methode statique
            // static = figé
            // qd un élément est statique il n'evolue pas / il est figé
            // traitement fixe
            // l'interet du mot static => on peut appeler sans instancier 
            // voitures = VoitureBDD.SelectAllStatique();

            // appel classique
            // creation objet voiture bdd
            // VoitureBDD vbdd = new VoitureBDD();
            // voitures = vbdd.SelectAll();

            voitures = VoitureBDD.SelectAllBDD();


            // afficher voitures
            foreach (Voiture v in voitures)
            {
                Console.WriteLine("Voiture roule a " + v.GetVitesseMax());
            }
        }
    }
}
