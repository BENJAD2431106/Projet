using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Menu
    {
        public List<Plat> Plats { get; set; }

        public Menu()
        {
            Plats = new List<Plat>();
            CreerPlats();

        }
        public void CreerPlats()
        {
            Plat plat = new Plat("Pizza 4 fromages", 15.75, 2, ["Fromage", "Fromage", "Fromage", "Fromage", "Tomate", "Farine", "Pate"], 9.5, Disponibilite.Dispo);
            Plat plat1 = new Plat("Burger", 13.50, 2, ["Fromage", "Pain", "Tomate", "Sauce", "Salade"], 7, Disponibilite.Dispo);
            Plat plat2 = new Plat("Poutine", 15.75, 2, ["Fromage", "Frites", "Sauce"], 9.5, Disponibilite.Dispo);
            Plat plat3 = new Plat("Shawarma", 17.75, 5, ["Fromage", "oignon", "poivron", "Pain", "Sauce"], 11, Disponibilite.Dispo);
            Plats.Add(plat1); Plats.Add(plat2); Plats.Add(plat3); Plats.Add(plat);
            Plat pl = new Plat("Burger Saumon", 13.50, 8, ["Fromage", "Pain", "Tomate", "Sauce", "Salade", "Saumon"], 7, Disponibilite.Indispo);
            Plat pl2 = new Plat("Poutine Maxi", 15.75, 4, ["Fromage", "Frites", "Sauce"], 9.5, Disponibilite.Indispo);
            Plat pl3 = new Plat("Shawarma Bacon", 17.75, 7, ["Fromage", "oignon", "poivron", "Pain", "Sauce", "Bacon"], 11, Disponibilite.Indispo);
            Plats.Add(pl); Plats.Add(pl2); Plats.Add(pl3);
        }
        public void AjouterPlat(Plat plat)
        {
            Plats.Add(plat);
        }

        public void SupprimerPlat(Plat plat)
        {
            Plats.Remove(plat);
        }
        public string AfficherPlatsDispo()
        {
            string info = "";
            int cpt = 0;
            info += "Menu J'A Resto\n";
            foreach (var plat in Plats)
            {
                if (plat.Disponibilite == Disponibilite.Dispo)
                {
                    cpt++;
                    info += cpt + "" + plat + "\n";
                }
            }
            return info;
        }
        public string AfficherPlatsIndispo()
        {
            string info = "";
            int cpt = 0;
            info += "Menu J'A Resto\n";
            foreach (var plat in Plats)
            {
                if (plat.Disponibilite == Disponibilite.Indispo)
                {
                    cpt++;
                    info += cpt + "" + plat + "\n";
                }
            }
            return info;
        }

        public override string ToString()
        {
            string info = "";
            int cpt = 0;
            info += "Menu J'A Resto\n";
            foreach (var plat in Plats)
            {
                    cpt++;
                    info += cpt + "" + plat + "\n";
            }
            return info;
        }
    }
}
