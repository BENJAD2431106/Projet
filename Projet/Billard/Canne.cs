using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Billard
{
    public enum Poids
    {
        Léger,
        Moyen,
        Lourd
    }
    public partial class Canne
    {
        string Nom { get; set; }
        int Visee { get; set; }
        int Force { get; set; }
        int Poids { get; set; }
        Poids CatPoids { get; set; }
        public Canne()
        {
            Nom = "Canne par défaut";
            Visee = 5;
            Force = 5;
            Poids = 20;
            DeterminerCategorie();
        }
        public Canne(string nom, int visee, int force, int poids)
        {
            Nom = nom;
            Visee = visee;
            Force = force;
            Poids = poids;
        }
        public void DeterminerCategorie()
        {
            if (Poids < 15)
            {
                CatPoids = Billard.Poids.Léger;
            }
            else if (Poids < 15 && Poids < 30)
            {
                CatPoids = Billard.Poids.Moyen;
            }
            else
            {
                CatPoids = Billard.Poids.Lourd;
            }

        }
        public override string ToString()
        {
            return "Canne " + Nom + " de visée " + Visee + ", Force " + Force + ", catégorie de Poids " + CatPoids;
        }
    }
}
