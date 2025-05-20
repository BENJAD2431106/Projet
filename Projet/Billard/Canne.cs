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
        int Masse { get; set; }
        public Poids CatPoids { get; set; }
        public Canne()
        {
            Nom = "Canne par défaut";
            Visee = 5;
            Force = 5;
            Masse = 20;
            CatPoids = Poids.Moyen;
            DeterminerCategorie();
        }
        public Canne(string nom, int visee, int force, int poids)
        {
            Nom = nom;
            Visee = visee;
            Force = force;
            Masse = poids;
            DeterminerCategorie();
        }
        public void DeterminerCategorie()
        {
            if (Masse < 15)
            {
                CatPoids = Poids.Léger;
            }
            else if (Masse >= 15 && Masse < 30)
            {
                CatPoids = Poids.Moyen;
            }
            else
            {
                CatPoids = Poids.Lourd;
            }

        }
        public override string ToString()
        {
            return "Canne " + Nom + " de visée " + Visee + ", Force " + Force + ", catégorie de Poids " + CatPoids;
        }
    }
}
