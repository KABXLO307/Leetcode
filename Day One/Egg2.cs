    internal class Program
    {
        static void Main(string[] args)
        {
            TopEgg();
            BottomEgg();
            MiddleEgg();
            Console.WriteLine("");
            TopEgg();
            BottomEgg();
            MiddleEgg();
            BottomEgg();
            Console.WriteLine("");
            TopEgg();
            MiddleEgg();
            BottomEgg();
        }


        public static void TopEgg()
        {
            Console.WriteLine("  _______");
            Console.WriteLine(" /       \\");
            Console.WriteLine("/         \\");
        }

        public static void BottomEgg()
        {
            Console.WriteLine("\\         /");
            Console.WriteLine(" \\_______/");
        }

        public static void MiddleEgg()
        {
            Console.WriteLine("-\"-'-\"-'-\"-");
        }
    }
}
