using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Menu
    {
        List<Plat> plats = new List<Plat>();

        public Menu(){ }

        public void AjouterPlat(Plat plat)
        {
            plats.Add(plat);
        }

        public void SupprimerPlat(Plat plat)
        {
            plats.Remove(plat);
        }
        
        public override string ToString()
        {
            string info = "";
            info += "Menu J'A Resto\n";
            foreach (var plat in plats)
            {
                info += plat + "\n";
            }
            return info;
        }
    }
}
