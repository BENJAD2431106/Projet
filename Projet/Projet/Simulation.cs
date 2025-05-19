using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Simulation
    {
        Random rand = new Random();
        List<Personne> Personnes { get; set; }
        Restaurant Restaurant { get; set; }
        List<Client> listClients { get; set; }
        UsineClient Usine { get; set; }
        public Simulation()
        {
            Restaurant = new Restaurant("J'A Resto", 60, 100); //début capital de 100
            listClients = new List<Client>();

            for (int i = 0; i < 5; i++)
            {
                listClients.Add(Restaurant.UsineClient.CreerClient());
            }
        }
        public void LancerSimulation()
        {
            int choix = 0;
            int choix1 = 0;
            do
            {
                AfficherMenu();
                string input = Console.ReadLine();
                try
                {
                    choix = Convert.ToInt32(input);
                }
                catch (FormatException) { Console.WriteLine("Entrez un entier svp."); }

                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 1:\n");
                        Restaurant.AfficherStatutResto();
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Vous avez choisi le choix 2:\n");
                            AfficherMenuClients();
                            string input1 = Console.ReadLine();
                            try
                            {
                                choix1 = Convert.ToInt32(input1);
                            }
                            catch (FormatException) { Console.WriteLine("Entrez un entier svp."); }
                            switch (choix1)
                            {
                                case 1:
                                    Console.WriteLine("Vous avez choisi le choix 1:\n");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Client client = Restaurant.UsineClient.CreerClient();
                                        Restaurant.Clients.Add(client);
                                        Console.WriteLine(client);
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Vous avez choisi le choix 2:\n");
                                    foreach(var  client in Restaurant.Clients)
                                    {
                                        Facture facture = new Facture(client, Restaurant.Menu.Plats[rand.Next(Restaurant.Menu.Plats.Count)]);
                                        Restaurant.Factures.Add(facture);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Vous avez choisi le choix 3:\nVoici les Clients et leur choix.");
                                    foreach(var fac in Restaurant.Factures)
                                    {
                                        Console.WriteLine(fac);
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Vous avez choisi le choix 1:\n");
                                    for (int i = 0; i < 10; i++)
                                    {
                                        Client client = Restaurant.UsineClient.CreerClient();
                                        Restaurant.Clients.Add(client);
                                        Console.WriteLine(client);
                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("Vous avez choisi le choix 5:\nLe nom prénom exact du client.");
                                    string reponseClient = Console.ReadLine();
                                    foreach (var client in Restaurant.Clients)
                                    {
                                        if (reponseClient == client.Nom)
                                        {
                                            Restaurant.Clients.Remove(client);
                                            Console.WriteLine(client.Nom+" sorti.");
                                        }
                                    }

                                    break;
                            }


                        } while (choix != 5);
                        break;
                    case 3:
                        Console.WriteLine("Vous avez choisi le choix 3:\n");
                        Console.WriteLine("Voici vos plats :" + Restaurant.Menu);
                        Console.WriteLine("Voulez-vous (S)upprimer ou (A)jouter un plat?");
                        char choixMenu = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        switch (choixMenu)
                        {
                            case 'A':
                                Restaurant.AfficherChangementAjout();
                                break;
                            case 'S':
                                Restaurant.AfficherChangementSupp();
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 4: Achat de nouveaux plats.\n");
                        Console.WriteLine("Entrer le nom du plat");
                        string platChoix = Console.ReadLine();
                        Console.WriteLine("Entrez l'ingrédient principal pour ce plat.");
                        string ingred = Console.ReadLine();
                        Plat plat = TrouverIngredient(platChoix, ingred);
                        Console.WriteLine("Votre menu présentement : " + Restaurant.Menu);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 5:\n");
                        Console.WriteLine("Commander Quel ingrédient?");
                        string ingredientChoix = Console.ReadLine();
                        AcheterIngredients(ingredientChoix);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }

            } while (choix != 7);
        }

        void AfficherMenu()
        {
            Console.WriteLine("1 => Regarder le status de J'A resto");
            Console.WriteLine("2 => S'Occuper des différents clients ");
            Console.WriteLine("3 => Ajuster le menu");
            Console.WriteLine("4 => Acheter de nouveaux plats ");
            Console.WriteLine("5 => Commandes les ingrédients ");
        }

        void AfficherMenuClients()
        {
            Console.WriteLine("1 => Ajouter des clients");
            Console.WriteLine("2 => Servir les clients");
            Console.WriteLine("3 => Checker les choix des clients");
            Console.WriteLine("4 => Servir un client particulier");
            Console.WriteLine("5 => Faire Quitter un client");
        }

        Plat TrouverIngredient(string plat, string ingredient)
        {
            foreach (var item in Restaurant.listIngredients)
            {
                if (ingredient == item.Nom)
                {
                    Restaurant.Menu.AjouterPlat(new Plat(plat, rand.Next(12, 25), rand.Next(11), [ingredient], rand.Next(5, 12), Disponibilite.Dispo));
                    return new Plat(plat, rand.Next(12, 25), rand.Next(11), [ingredient], rand.Next(5, 12), Disponibilite.Dispo);
                }
            }
            Console.WriteLine("Ingrédient indisponible.");
            Console.WriteLine("Dirigez-vous plutot vers l'interface d'achat d'ingrédients.");
            return null;
        }
        void AcheterIngredients(string ingr)
        {
            try
            {
                Ingredient ingredient = new Ingredient(ingr, rand.Next(1, 150), "Bonne", rand.Next(1, 6));
                Restaurant.listIngredients.Add(ingredient);
                Restaurant.Argent -= ingredient.Prix;
                if (Restaurant.Argent < ingredient.Prix)
                    throw new Exception("Pas d'argent !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

