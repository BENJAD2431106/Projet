using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Facture
    {
        Client Client { get; set; }
        List <Plat> Plats { get; set; } = new List<Plat>();
        double Montant { get; set; }

        public Facture(Client cl, Plat plat)
        {
            Client = cl;
            Plats.Add(plat);
            Montant += plat.Prix;
        }
        public string AfficherPlats()
        {
            string infos = "";
            foreach (Plat plat in Plats)
            {
                infos += plat + "\n";
            }
            return infos;
        }
        public override string ToString()
        {
            return "Facture : " + Client.Nom + " " + Client.Prenom + " achète " + AfficherPlats() + " Montant total débourssé : " + Montant;
        }
        //public void AjouterPlat(Plat plat)
        //{
        //    Plats.Add(plat);
        //}
    }
}
