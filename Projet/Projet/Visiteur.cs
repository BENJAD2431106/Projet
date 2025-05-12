using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Visiteur : Personne
    {
        public Visiteur(string nom, string prenom) : base(nom, prenom)
        {

        }
        public override string ToString()
        {
            return base.ToString() + " est un visiteur.";
        }
    }
}
