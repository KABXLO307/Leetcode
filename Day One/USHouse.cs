namespace PracticeIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            roof();
            middleHouse();
            paintHouse();
            middleHouse();
            roof();

        }


        public static void roof()
        {
            Console.WriteLine("   /\\       /\\");
            Console.WriteLine("  /  \\     /  \\");
            Console.WriteLine(" /    \\   /    \\");
        }

        public static void middleHouse()
        {
            Console.WriteLine("+------+ +------+");
            Console.WriteLine("|      | |      |");
            Console.WriteLine("|      | |      |");
            Console.WriteLine("+------+ +------+");
        }

        public static void paintHouse()
        {
            Console.WriteLine("|United| |United|");
            Console.WriteLine("|States| |States|\r\n");
        }
    }
}
