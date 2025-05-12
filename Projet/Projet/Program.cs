namespace Projet
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


