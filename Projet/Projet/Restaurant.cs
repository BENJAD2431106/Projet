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
        string Nom {  get; set; }
        int personneMax { get; set; }
        List<Visiteur> Visiteurs {  get; set; }
        List<Client> Clients { get; set; }
        Menu Menu {  get; set; }
        Status Status { get; set; }
        public Restaurant(string nom, Status status, int personneMax)
        {
            Nom = nom;
            Visiteurs = new List<Visiteur>();
            Clients = new List<Client>();
            Status = status;
            Menu = new Menu();
            this.personneMax = personneMax;
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
            foreach(Client client in Clients)
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
            foreach (Visiteur vis in  Visiteurs)
            {
                nombrePers++;
            }
            return nombrePers;
        }
        public void AfficherChoixClient()
        {
            Console.WriteLine(Menu);
            Console.WriteLine("Écrivez le nom exact du plat que vous voulez.");
            string choix = Console.ReadLine();
            foreach(Plat plat in  Menu.plats)
            {
                if(choix==plat.Nom)
                {
                    Console.WriteLine("Vous avez choisi "+choix);
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
            if (AfficherPlein())
            {
                Console.WriteLine("Encore " + (personneMax - Clients.Count + Visiteurs.Count) + " places.");
            }
            else
                Console.WriteLine("Plein...");
        }

        public override string ToString()
        {
            return "Le restaurant " + Nom + " statut : "+Status+" nombre Clients : "+CompterClient();
        }
    }
}
 