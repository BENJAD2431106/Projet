using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    internal class Employe : Personne
    {
        double Salaire { get; set; }
        public Employe(string nom, string prenom, double salaire) : base(nom, prenom)
        {
            Salaire=salaire;
        }
        public override string ToString()
        {
            return base.ToString() + " est un employé au salaire fix de "+Salaire;
        }
    }
}
