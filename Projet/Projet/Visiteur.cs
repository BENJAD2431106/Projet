using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Visiteur : Personne
    {
        public Visiteur(string nom, string prenom, Temperamant temperamant) : base(nom, prenom, temperamant)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " est un visiteur.";
        }
    }
}
