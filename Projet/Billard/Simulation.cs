using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billard
{
    public class Simulation
    {
        Random rand = new Random();
        public List<Boule> Boules { get; set; }
        public Joueur Joueur { get; set; }

        public Simulation()
        {
            Boules = CreerBoules();
            Joueur = new Joueur();
        }
        public void Simuler()
        {
            Joueur = CreerJoueur();
            int choix1 = 0;
            do
            {
                AfficherMenu();
                string input1 = Console.ReadLine();
                try
                {
                    choix1 = Convert.ToInt32(input1);
                }
                catch (FormatException) { Console.WriteLine("Entrez un entier svp."); }
                switch (choix1)
                {
                    case 1:
                        foreach (Boule boule in Boules)
                        {
                            Console.WriteLine(boule);
                        }
                        break;
                    case 2:
                        Console.WriteLine(Joueur);
                        break;
                    case 3:
                        foreach (Boule boule in Boules)
                        {
                            if (boule.Statut == Statut.Rentree)
                            {
                                Console.WriteLine(boule);
                            }
                        }
                        Console.WriteLine("Il vous reste :\n");
                        foreach (Boule boule in Boules)
                        {
                            if (boule.Statut == Statut.Dispo)
                            {
                                Console.WriteLine(boule);
                            }
                        }
                        break;
                    case 4:
                        EssayerJeu();
                        break;
                }
            } while (choix1 != 4);
        }
        public void EssayerJeu()
        {
            Joueur ordi = new Joueur();
            int numero = rand.Next(1, 16);
            int cpt = 1;
            int no = rand.Next(1, 3);
            foreach (Boule boule in Boules)
            {
                if (!VerifierNoire() && boule.Numero == 8)
                {
                    Console.WriteLine("Vous avez PERDU... " + Joueur.Nom + " a rentrée la " + boule.Type);
                    break;
                }
                else if (numero == boule.Numero && boule.Statut == Statut.Dispo)
                {
                    if(boule.Numero==8)
                    {
                        Console.WriteLine("Vous avez GAGNÉ!!! " + Joueur.Nom + " a rentrée la " + boule.Type);
                    }
                    if (no == 2)
                    {
                        Console.WriteLine("Boule " + boule.Numero + " rentrée par " + Joueur.Nom);
                        boule.Statut = Statut.Rentree;
                        cpt++;
                    }
                    else
                    {
                        Console.WriteLine("Tentative de rentrer la boule " + boule.Numero + " échouée");
                    }

                }
            }
            /////////////faire tour par tour 
            ///arranger aaffaire catPoids
            ///dans projet faire menu quitter
            Console.WriteLine("Tour de Ordi :");
            foreach (Boule boule in Boules)
            {
                if (!VerifierNoire() && boule.Numero == 8)
                {
                    if (boule.Numero == 8)
                    {
                        Console.WriteLine("Vous avez PERDU... " + ordi.Nom + " a rentrée la " + boule.Type);
                    }
                    break;
                }
                else if (numero == boule.Numero && boule.Statut == Statut.Dispo)
                {
                    Console.WriteLine("Vous avez perdu... " + Joueur.Nom + " a rentrée la " + boule.Type);
                    if (no == 2)
                    {
                        Console.WriteLine("Boule " + boule.Numero + " rentrée par " + ordi.Nom);
                        boule.Statut = Statut.Rentree;
                        cpt++;
                    }
                    else
                    {
                        Console.WriteLine("Tentative de rentrer la boule " + boule.Numero + " échouée");
                    }

                }
            }
        }
        public bool VerifierNoire()
        {
            bool rentree = false;
            foreach (Boule boule in Boules)
            {
                if (boule.Numero != 8)
                {
                    if (boule.Statut == Statut.Rentree)
                    {
                        rentree = true;
                    }
                    else
                        return false;
                }
            }
            return rentree;
        }
        public List<Boule> CreerBoules()
        {
            List<Boule> boules = new List<Boule>();
            for (int i = 0; i < 15; i++)
            {
                Boule boule = new Boule();
                boules.Add(boule);
            }
            return boules;
        }
        public Joueur CreerJoueur()
        {
            int choix1 = 0;
            Console.WriteLine("Souhaitez-vous créer un joueur par défaut ?\n1-Oui, 2-Non.");
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
                    return new Joueur();
                    break;
                case 2:
                    Console.WriteLine("Vous avez choisi le choix 2:\n");
                    Console.WriteLine("Quel nom attribuer à votre joueur.");
                    string nom = Console.ReadLine();
                    Console.WriteLine("quel nom pour la canne?");
                    string nomCanne = Console.ReadLine();
                    Console.WriteLine("quel poids pour la canne?");
                    int poids = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("quelle visée pour la canne?");
                    int visee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("quelle force pour la canne?");
                    int force = Convert.ToInt32(Console.ReadLine());
                    Canne canne = new Canne(nomCanne, visee, force, poids);
                    return new Joueur(nom, canne);
                    break;
            }
            return null;
        }

        void AfficherMenu()
        {
            Console.WriteLine("1 => Regarder le nombre de boules totales.");
            Console.WriteLine("2 => Visualiser votre joueur.");
            Console.WriteLine("3 => Regarder le nombre de boules totales Rentrées.");
            Console.WriteLine("4 => Jouer.");
        }
    }
}
