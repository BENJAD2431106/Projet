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
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (choix1 != 5);
        }
        public void EssayerJeu()
        {
            Joueur ordi = new Joueur("Ordi");
            int cpt = 0;
            int cpt1 = 0;
            bool sortir = true;
            while (sortir)
            {
                int no = rand.Next(1, 3);
                int numero = rand.Next(1, 16);
                Boule boule = null;
                foreach (Boule b in Boules)
                {
                    if (b.Numero == numero && b.Statut == Statut.Dispo)
                    {
                        boule = b;
                        break; // On a trouvé la bonne boule, on quitte la boucle
                    }
                }
                Console.WriteLine("Tour de : " + Joueur.Nom);
                if (boule is null)
                {
                    Console.WriteLine("Aucne boule à jouer.");
                }
                else if (boule != null)
                {
                    if (!VerifierNoire() && boule.Numero == 8)
                    {
                        Console.WriteLine("Vous avez PERDU... " + Joueur.Nom + " a rentré la " + boule.Type);
                        sortir = false;
                        break;
                    }
                    else if (boule.Numero == 8 && VerifierNoire())
                    {
                        Console.WriteLine("Vous avez GAGNÉ !!! " + Joueur.Nom + " a rentré la noire !");
                        sortir = false;
                        break;
                    }
                    else if (boule.Statut == Statut.Dispo)
                    {
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
                Console.ReadLine();
                Console.WriteLine("Tour de Ordi :");
                int no1 = rand.Next(1, 3);
                int numero1 = rand.Next(1, 16);
                boule = null;
                foreach (Boule b in Boules)
                {
                    if (b.Numero == numero1 && b.Statut == Statut.Dispo)
                    {
                        boule = b;
                        break; // On a trouvé la bonne boule, on quitte la boucle
                    }
                }
                if(boule is null)
                {
                    Console.WriteLine("Aucne boule à jouer.");
                }
                else if (boule != null)
                {
                    if (!VerifierNoire() && boule.Numero == 8)
                    {
                        Console.WriteLine("Vous avez GAGNÉ... " + ordi.Nom + " a rentré la " + boule.Type);
                        sortir = false;
                        break;
                    }
                    else if (boule.Numero == 8 && VerifierNoire())
                    {
                        Console.WriteLine("Vous avez GAGNÉ !!! " + Joueur.Nom + " a rentré la noire !");
                        sortir = false;
                        break;
                    }
                    else if (boule.Statut == Statut.Dispo)
                    {
                        if (no1 == 2)
                        {
                            Console.WriteLine("Boule " + boule.Numero + " rentrée par " + ordi.Nom);
                            boule.Statut = Statut.Rentree;
                            cpt1++;
                            sortir = true;
                        }
                        else
                        {
                            Console.WriteLine("Tentative de rentrer la boule " + boule.Numero + " échouée");
                        }

                    }
                }
                Console.ReadLine();
            }
            Console.ReadLine();
            Console.WriteLine(cpt+" boules rentrées par "+Joueur.Nom+" , et "+cpt1+" boules rentrées par "+ordi.Nom);
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
            }
            return null;
        }

        void AfficherMenu()
        {
            Console.WriteLine("1 => Regarder le nombre de boules totales.");
            Console.WriteLine("2 => Visualiser votre joueur.");
            Console.WriteLine("3 => Regarder le nombre de boules totales Rentrées.");
            Console.WriteLine("4 => Jouer.");
            Console.WriteLine("5 => Quitter.");
        }
    }
}

