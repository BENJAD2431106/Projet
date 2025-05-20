using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Projet
{
    public enum Status
    {
        Plein,
        Vide,
        Dispo
    };
    public partial class Restaurant
    {
        public List<Ingredient> listIngredients { get; set; }
        public string Nom { get; set; }
        public int personneMax { get; set; }
        public double Argent { get; set; }
        public List<Facture> Factures { get; set; }
        public List<Visiteur> Visiteurs { get; set; }
        public UsineClient UsineClient { get; set; }
        public List<Client> Clients { get; set; }
        public Menu Menu { get; set; }
        public Status Status { get; set; }
        public Restaurant(string nom, int personneMax, double argent)
        {
            Argent = argent;
            Nom = nom;
            Factures = new List<Facture>();
            Visiteurs = new List<Visiteur>();
            UsineClient = new UsineClient();
            Clients = new List<Client>();
            Menu = new Menu();
            if ((Clients.Count + Visiteurs.Count <= personneMax) && (Clients.Count + Visiteurs.Count > 0))
            {
                Status = Status.Dispo;
            }
            else if ((Clients.Count + Visiteurs.Count > personneMax))
            {
                Status = Status.Plein;
            }
            else if ((Clients.Count + Visiteurs.Count == 0))
            {
                Status = Status.Vide;
            }
            Menu = new Menu();
            this.personneMax = personneMax;
            Initialiser();
        }


        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
        public void AjouterVisiteur(Visiteur visiteur)
        {
            Visiteurs.Add(visiteur);
        }
        public int CompterClient()
        {
            int nombreClient = 0;
            foreach (Client client in Clients)
            {
                nombreClient++;
            }
            return nombreClient;
        }
        public int CompterPersonne()
        {
            int nombrePers = 0;
            foreach (Client client in Clients)
            {
                nombrePers++;
            }
            foreach (Visiteur vis in Visiteurs)
            {
                nombrePers++;
            }
            return nombrePers;
        }
        public void AfficherChangementSupp()
        {
            Console.WriteLine(Menu);
            Console.WriteLine("Écrivez le nom exact du plat que vous voulez Supprimer.");
            string choix = Console.ReadLine();
            foreach (Plat plat in Menu.Plats)
            {
                if (choix == plat.Nom)
                {
                    Console.WriteLine("Vous avez choisi " + choix);
                    plat.Disponibilite = Disponibilite.Indispo;
                }
            }
        }
        public void AfficherChangementAjout()
        {
            Console.WriteLine(Menu);
            Console.WriteLine("Écrivez le nom exact du plat que vous voulez ajouter.");
            string choix = Console.ReadLine();
            foreach (Plat plat in Menu.Plats)
            {
                if (choix == plat.Nom)
                {
                    Console.WriteLine("Vous avez choisi " + choix);
                    plat.Disponibilite = Disponibilite.Dispo;
                }
            }
        }
        public void AfficherChoixClient()
        {
            Console.WriteLine(Menu);
            Console.WriteLine("Écrivez le nom exact du plat que vous voulez.");
            string choix = Console.ReadLine();
            foreach (Plat plat in Menu.Plats)
            {
                if (choix == plat.Nom)
                {
                    Console.WriteLine("Vous avez choisi " + choix);
                }
            }
        }
        public bool AfficherPlein()
        {
            bool val;
            if (Clients.Count + Visiteurs.Count <= personneMax)
            {
                val = true;
            }
            else
                val = false;

            return val;
        }
        public void AfficherStatutResto()
        {
            Console.WriteLine("Restaurant " + Nom + " capacité maximale de clients " + personneMax + "\nLes ingrédients actuellement Disponibles :");
            foreach (var item in listIngredients)
            {
                Console.WriteLine(item);
            }

            if (AfficherPlein())
            {
                Console.WriteLine("Encore " + (personneMax - Clients.Count + Visiteurs.Count) + " places.");
            }
            else
                Console.WriteLine("Plein...");
        }

        public void Initialiser()
        {
            listIngredients = JsonFileLoader.ChangerFichier<List<Ingredient>>("json_ingredient.json");
        }

        public override string ToString()
        {
            return "Le restaurant " + Nom + "\nstatut : " + Status + " nombre Clients : " + CompterClient();
        }
    }
}
