using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billard
{
    public class Joueur
    {
        public string Nom {  get; set; }
        Canne Canne { get; set; }
        public Joueur()
        {
            Nom = "Vincent";
            Canne = new Canne();
        }
        public Joueur(string nom, Canne canne)
        {
            Nom = nom;
            Canne = canne;
        }
        public Joueur(string nom)
        {
            Nom = nom;
            Canne = new Canne();
        }
        public override string ToString()
        {
            return Nom + " a la canne : " + Canne;
        }
    }
}
