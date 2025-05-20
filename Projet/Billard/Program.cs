namespace Billard
{
    public class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.Simuler();
        }

        //static List<Boule> CreerBoules()
        //{
        //    List <Boule> boules = new List <Boule>();
        //    for(int i = 0;i<15;i++)
        //    {
        //        Boule boule = new Boule();
        //        boules.Add(boule);
        //    }
        //    return boules;
        //}
    }
}
