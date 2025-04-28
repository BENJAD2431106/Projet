using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Client : Personne
    {
        double Montant {  get; set; }
        public Client(string nom, string prenom,Temperamant temperament, double montant) : base(nom, prenom, temperament)
        {
            Montant = montant;
        }
        public override string ToString()
        {
            return base.ToString() + " est un client." ;
        }
    }
}
