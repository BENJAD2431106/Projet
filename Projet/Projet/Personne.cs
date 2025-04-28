using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public enum Temperamant
    {
        Calme,
        Stresse,
        Pointilleux
    };
    public partial class Personne
    {
        string Nom {  get; set; }
        string Prenom { get; set; }
        Temperamant Temperamant { get; set; }
        public Personne(string nom, string prenom, Temperamant temperamant)
        {
            Nom = nom;
            Prenom = prenom;
            Temperamant = temperamant;
        }
        public override string ToString()
        {
            return "La personne " + Nom + " " + Prenom;
        }
    }
}
