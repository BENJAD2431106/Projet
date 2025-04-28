using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class UsineClient
    {
        public UsineClient()
        {           

        }
        public Client CreerClient()
        {
            string[] prenoms = {
            "Liam", "Edouard", "Noah", "Eloi", "Thomas", "Felix", "Samuel", "Emile", "Alexandre", "Leo",
            "Theo", "Alexis", "Maxime", "Nathan", "Arthur", "Elliot", "Henri", "Jacob", "Olivier", "Emma",
            "Florence", "Lea", "Charlie", "Alice", "Romy", "Olivia", "Charlotte", "Beatrice", "Laurence",
            "Livia", "Laurie", "Billie", "Ophelie", "Camille", "Zoe", "Flavie", "Rosalie", "Rose", "Chloe"
        };

            string[] noms = {
            "Tremblay", "Gagnon", "Roy", "Côté", "Bouchard", "Gauthier", "Morin", "Lavoie", "Fortin", "Gagné",
            "Ouellet", "Pelletier", "Bélanger", "Lévesque", "Bergeron", "Leblanc", "Paquette", "Girard", "Simard",
            "Boucher", "Caron", "Beaulieu", "Cloutier", "Dubé", "Poirier", "Fournier", "Lapointe", "Leclerc",
            "Lefebvre", "Poulin", "Thibault", "St-Pierre", "Nadeau", "Martin", "Landry", "Martel", "Bédard"
        };

            Random rnd = new Random();
            Temperamant[] tabTemp = [Temperamant.Calme, Temperamant.Stresse, Temperamant.Pointilleux];
            Temperamant rand = tabTemp[rnd.Next(tabTemp.Length)];
            string prenom = prenoms[rnd.Next(prenoms.Length)];
            string nom = noms[rnd.Next(noms.Length)];
            double mt = rnd.Next(10, 10000000);
            Client client = new Client(nom, prenom, rand, mt);
            return client;
        }
    }
}
