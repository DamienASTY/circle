using System;
using System.Collections.Generic;
using System.Text;

namespace circle
{
    class Cercle
    {

        public void CalculeAir()
        {
            bool ok = false;
            char recommencer;
            double rayon = 0;
            double air = 0;
            double per = 0;
            while(ok != true)
            {
                try
                {
                    Console.Write("Entrez le rayon de votre cercle :");
                    rayon = double.Parse(Console.ReadLine());
                    air = this.calcAir(rayon);
                    per = this.calcPer(rayon);
                    Console.WriteLine($"Le cercle de rayon {rayon} a un périmètre de {per} et une aire de {air}");
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("");
                }
            }
            try
            {
                Console.WriteLine("Voulez-vous recommencez ? y: oui; q: non");
                recommencer = char.Parse(Console.ReadLine());
                if(recommencer == 'y')
                {
                    this.CalculeAir();
                }
            }
            catch
            {
                Console.WriteLine("Fermeture du programme");
            }
            
        }

        private double calcAir(double r)
        {
            return Math.PI * (r * r);
        }

        private double calcPer(double r)
        {
            return r * Math.PI;
        }
    }
}
