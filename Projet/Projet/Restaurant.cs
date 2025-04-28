using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    enum Status
    {
        Plein,
        Vide,
        Dispo
    };
    public partial class Restaurant
    {
        string Nom {  get; set; }
        List<Visiteur> visiteurs;
        List<Client> clients;
        Menu menu;
        Status status;
        public Restaurant(string nom)
        {
            Nom = nom;
            visiteurs = new List<Visiteur>();
            clients = new List<Client>();
        }
        public void AjouterClient(Client client)
        {
            clients.Add(client);
        }
        public void AjouterVisiteur(Visiteur visiteur)
        {
            visiteurs.Add(visiteur);
        }
        public int CompterClient()
        {
            int nombreClient = 0;
            foreach(Client client in clients)
            {
                nombreClient++;
            }
            return nombreClient;
        }
        public int CompterPersonne()
        {
            int nombrePers = 0;
            foreach (Client client in clients)
            {
                nombrePers++;
            }
            foreach (Visiteur vis in  visiteurs)
            {
                nombrePers++;
            }
            return nombrePers;
        }
        public override string ToString()
        {
            return "Le restaurant " + Nom + " statut : "+status+" nombre Clients : "+CompterClient();
        }
    }
}
