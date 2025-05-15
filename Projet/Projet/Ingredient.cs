using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projet
{
    public enum Qualite
    {
        Moyen,
        Bonne,
        Excellente
    }

    public partial class Ingredient

    {
        public string Nom { get; set; }
        public int Calories { get; set; }
        public Qualite QualiteIng { get; set; }
        public float Prix { get; set; }
        public List<Ingredient> listIngredients { get; set; }

        [JsonConstructor]
        public Ingredient(string nom, int calories, string qualite, float prix)
        {
            Nom = nom;
            Calories = calories;
            if (qualite.Contains("Moyenne"))
                QualiteIng = Qualite.Moyen;
            else if (qualite.Contains("Bonne"))
                QualiteIng = Qualite.Bonne;
            else
                QualiteIng = Qualite.Excellente;
            Prix = prix;
            listIngredients = new List<Ingredient>();
        }

       
        public override string ToString()
        {
            return Nom + " " + QualiteIng + " Cals : " + Calories + " & Prix : " + Prix;
        }
    }
}
