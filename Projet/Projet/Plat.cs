using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public enum Disponibilite
    {
        Dispo,
        Indispo
    }
    public partial class Plat
    {
        public string Nom {  get; set; }
        public double Prix { get; set; }
        int Rarete   { get; set; }
        List<string> Ingredients { get; set; }
        double PrixRecette { get; set; }
        public Disponibilite Disponibilite { get; set; }
        public Plat (string nom, double prix, int rarete, List<string> ingredients, double prixRecette, Disponibilite disponibilite)
        {
            Nom = nom;
            Prix = prix;
            Rarete = rarete;
            Ingredients = ingredients;
            PrixRecette = prixRecette;
            Disponibilite = disponibilite;
        }

        public string GetInfoIngr()
        {
            string info = "";
            foreach (var ingredient in Ingredients)
            {
                info += ingredient + " ";
            }
            return info;
        }



        public override string ToString()
        {
            return $"Plat; {Nom} {Prix}$ \n Rareté: {Rarete}/10\n Les ingrédients: {GetInfoIngr()}\n Prix d'achat(Recette) : {PrixRecette} Disponibilité : {Disponibilite}\n";
        }
    }
}
