namespace Billard
{
    public class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            Simulation simulation = new Simulation();
            simulation.Simuler();
        }
    }
}
