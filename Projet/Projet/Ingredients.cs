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

    public partial class Ingredients
    {
        public string Nom { get; set; }
        public int Calorie { get; set; }
        public Qualite QualiteIng { get; set; }
        public float Prix { get; set; }

        [JsonConstructor]
        public Ingredients(string nom, int calorie, string quantite, float prix)
        {
            Nom = nom;
            Calorie = calorie;
            if (quantite.Contains("Moyenne"))
                QualiteIng = Qualite.Moyen;
            else if (quantite.Contains("Bonne"))
                QualiteIng = Qualite.Bonne;
            else
                QualiteIng = Qualite.Excellente;
            Prix = prix;    
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
