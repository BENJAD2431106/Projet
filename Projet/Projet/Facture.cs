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
        List <Plat> Plats { get; set; }
        double Montant { get; set; }

        public Facture(Client cl, Plat plat)
        {
            Client = cl;
            Plats = new List<Plat> { plat };
            Montant = plat.Prix;
        }
        public void AjouterPlat(Plat plat)
        {
            Plats.Add(plat);
        }
    }
}
