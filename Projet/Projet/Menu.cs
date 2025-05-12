using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Menu
    {
        public List<Plat> plats = new List<Plat>();

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
            int cpt = 0;
            info += "Menu J'A Resto\n";
            foreach (var plat in plats)
            {
                cpt++;
                info +=cpt +""+plat + "\n";
            }
            return info;
        }
    }
}
