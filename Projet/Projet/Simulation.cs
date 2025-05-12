using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public partial class Simulation
    {
        Personne Personne { get; set; }
        Plat Plat { get; set; }
        Restaurant Restaurant { get; set; }
        Ingredients Ingredients { get; set; }
        Client Client { get; set; }

        
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
                        Console.WriteLine("Vous avez choisi le choix 1:");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 2:");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 3:");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 4:");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Vous avez choisi le choix 5:");
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                }

            } while (choix != 7);
        }

        void AfficherMenu()
        {
            Console.WriteLine("1 => Regarder le status du J'A resto");
            Console.WriteLine("2 => Occuper des différents clients ");
            Console.WriteLine("3 => Ajuster le menu");
            Console.WriteLine("4 => Acheter de nouveau plat ");
            Console.WriteLine("5 => Commandes les ingrédients ");
        }

        void OccuperDesClients()
        {
           

        }

        void GenererClients()
        {
            int nombre = Program.rand.Next(2, 5);
            for (int i = 0; i < nombre; i++)
            {
                listPieces.Add(new PieceMusique());
            }
        }
    }
}
