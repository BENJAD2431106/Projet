using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Plat
    {
        public string Nom {  get; set; }
        double Prix { get; set; }
        int Rarete   { get; set; }
        List<string> Ingredients { get; set; }
        double PrixRecette { get; set; }

        public Plat (string nom, double prix, int rarete, List<string> ingredients, double prixRecette)
        {
            Nom = nom;
            Prix = prix;
            Rarete = Rarete;
            Ingredients = ingredients;
            PrixRecette = prixRecette;
        }

        public string GetInfoIngr()
        {
            string info = "";
            foreach (string ingredient in Ingredients)
            {
                info += ingredient + " ";
            }
            return info;
        }

        public override string ToString()
        {
            return $"Plat; {Nom} {Prix}$ \n Rareté: {Rarete}/10\n Les ingrédients: {GetInfoIngr()}\n Prix d'achat(Recette) : {PrixRecette} \n";
        }
    }
}
