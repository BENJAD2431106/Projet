using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Simulation
    {
        List<Personne> Personnes { get; set; }
        Restaurant Restaurant { get; set; }
        Ingredient Ingredient { get; set; }
        List<Ingredient> listIngredients { get; set; }
        List<Plat> listPlats { get; set; }
        List<Client> listClients { get; set; }
        UsineClient Usine { get; set; } 

        public Simulation()
        {
            Restaurant = new Restaurant("J'A Resto", 60);
            listClients = new List<Client>();
            
            for (int i = 0; i < 5; i++)
            {  
                listClients.Add(Restaurant.UsineClient.CreerClient());
            }
            


        }


        public void LancerSimulation()
        {
            int choix = 0;
            do
            {
                AfficherMenu();
                choix = Convert.ToInt32(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 1:\n");
                        Restaurant.AfficherStatutResto();   
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 2:\n");
                        AfficherMenuClients();
                        int choixSOccuperClients = Convert.ToInt32(Console.ReadLine());

                        switch (choixSOccuperClients)
                        {
                            case 1:
                                Console.WriteLine("Vous avez ajouté 10 nouveaux clients\n");

                                for (int i = 0; i < 10; i++)
                                {
                                    Client client = Restaurant.UsineClient.CreerClient();
                                    Restaurant.Clients.Add(client);
                                    listClients.Add(client);
                                    Console.WriteLine(client);
                                }
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.WriteLine("Voici nos clients:\n");
                                VoirListClients();
                                Console.WriteLine();
                                break;
                            case 3:
                                break;
                        }
                        
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 3:\n");
                        char choixMenu = Console.ReadKey().KeyChar;
                        Console.WriteLine("Voulez-vous (S)upprimer ou (A)jouter un plat?");
                        switch (choixMenu)
                        {
                            case 'A':
                                Console.WriteLine("Quel plat voulez vous ajouter?");
                                string platAjouter = Console.ReadLine();
                                break;
                            case 'S':
                                Console.WriteLine("Quel plat voulez vous supprimer?");
                                string platSupprimer = Console.ReadLine();
                                break;
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 4:\n");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 5:\n");
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
            Console.WriteLine("2 => Voir la liste de clients");
            Console.WriteLine("3 => Checker les choix des clients");
            Console.WriteLine("4 => Servir les clients");
        }

        void VoirListClients()
        {
            for (int i = 0; i < listClients.Count; i++)
            {
                Console.WriteLine($"{i + 1} => {listClients[i]}");
            }
        }
    }
}
