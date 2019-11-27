using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Voiture
    {
        private int vitesseMax;
        private EMarque marque;

        // constructeur
        // constructeur avec arguments
        public Voiture(int _vitesseMax, EMarque _marque)
        {
            int _vitesseMin = _vitesseMax / 10;
            vitesseMax = _vitesseMax;
            marque = _marque;
        }
        
        public int GetVitesseMax()
        {
            return vitesseMax;
        }

        public void SetVitesseMax(int _vitesseMax)
        {
            vitesseMax = _vitesseMax;
        }

        public void roule()
        {
            Console.WriteLine("Je roule à " + vitesseMax);
        }

        public static void TestStatique()
        {
            Console.WriteLine("je suis une methode statitque");
        }
    }
}
