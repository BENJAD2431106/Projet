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
    public partial class Client : Personne
    {
        double Montant {  get; set; }
        Temperamant Temperamant { get; set; }
        public Client(string nom, string prenom,Temperamant temperament, double montant) : base(nom, prenom)
        {
            Montant = montant;
            Temperamant = temperament;
        }
        public override string ToString()
        {
            return base.ToString() + " est un client." ;
        }
    }
}
