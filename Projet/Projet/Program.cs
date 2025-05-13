namespace Projet
{
    internal class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            //UsineClient usine = new UsineClient();
            //Client client = usine.CreerClient();
            //Client client1 = usine.CreerClient();
            //Client client2 = usine.CreerClient();
            //Console.WriteLine(client); Console.WriteLine(client2); Console.WriteLine(client1);
            Console.WriteLine("Bienvenue chez J'A Resto !");
            DessinerResto(); 
        }
        public static void DessinerResto()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] scene = new string[]
            {
            "        /\\                           ____                           /\\        ",
            "       /  \\                         /    \\                         /  \\       ",
            "      /    \\       /\\             /      \\             /\\       /    \\      ",
            "     /      \\     /  \\___________/        \\___________/  \\     /      \\     ",
            "    /        \\   /                                 \\   /        \\    ",
            "   /          \\_/                                   \\_/          \\   ",
            "  /                                                               \\  ",
            " /                                                                 \\ ",
            "/_______________________J'A Resto_______________________\\",
            "|                                                       |",
            "|     [=====]      [=====]      [=====]      [=====]     |",
            "|                                                       |",
            "|___________________________||__________________________|"
            };

            foreach (var line in scene)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("\nAppuie sur une touche pour quitter...");
            Console.ReadKey();
            Console.Clear();

            
            Simulation simulation = new Simulation();
            simulation.LancerSimulation();

        }
    }

}


