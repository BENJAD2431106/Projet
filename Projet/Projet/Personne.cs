using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{

    public partial class Personne
    {
        string Nom {  get; set; }
        string Prenom { get; set; }
        
        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }
        public override string ToString()
        {
            return "La personne " + Nom + " " + Prenom;
        }
    }
}
