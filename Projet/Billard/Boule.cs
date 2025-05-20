using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billard
{
    public enum Type
    {
        Rayee,
        Plaine,
        Noire
    }
    public enum Statut
    {
        Rentree,
        Dispo
    }
    public partial class Boule
    {
        Random rand = new Random();
        static int noBoule = 1;
        List <int> Numeros = new List <int>();
        public int Numero {  get; set; }
        public Type Type { get; set; }
        public Statut Statut { get; set; }
        public Boule()
        {
            Numero = noBoule++;
            Type = TrouverType();
            Statut = Statut.Dispo;
        }
        public void RemplirNumero()
        {
            for (int i = 0; i < Numeros.Count; i++)
            {
                Numeros[i] = i + 1;
            }
        }
        //effacer

        public Type TrouverType()
        {
            if (Numero >= 1 && Numero <= 7)
            {
                return Type.Plaine;
            }
            else if (Numero >= 9 && Numero <= 15)
            {
                return Type.Rayee;
            }
            else
                return Type.Noire;
        }

        public override string ToString()
        {
            return "Boule " + Numero + " de type " + Type + ", Status : "+Statut;
        }
    }
}
