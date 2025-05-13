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
            
        }
        public void CreerPlats()
        {
            Plat plat = new Plat("Pizza 4 fromages", 15.75, 2, ["Fromage","Fromage","Fromage", "Fromage","Tomate","Farine","Pate"],9.5);
            Plat plat1 = new Plat("Burger", 13.50, 2, ["Fromage", "Pain", "Tomate", "Sauce", "Salade"], 7);
            Plat plat2 = new Plat("Poutine", 15.75, 2, ["Fromage", "Frites", "Sauce"], 9.5);
            Plat plat3 = new Plat("Shawarma", 17.75, 5, ["Fromage", "oignon", "poivron", "Pain", "Sauce"], 11);
            Plats.Add(plat1);Plats.Add(plat2);Plats.Add(plat3);Plats.Add(plat);

        }
        public void AjouterPlat(Plat plat)
        {
            Plats.Add(plat);
        }

        public void SupprimerPlat(Plat plat)
        {
            Plats.Remove(plat);
        }
        
        public override string ToString()
        {
            string info = "";
            int cpt = 0;
            info += "Menu J'A Resto\n";
            foreach (var plat in Plats)
            {
                cpt++;
                info +=cpt +""+plat + "\n";
            }
            return info;
        }
    }
}
