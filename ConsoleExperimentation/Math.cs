namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
            Console.Title = "Watchtower";
            Console.WriteLine("Welcome to Watchtower!");
            Console.WriteLine("Press Any Key to Continue.. ");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Enter x value (1 - 3): ");
            string xVal = Console.ReadLine();
            int xValue = int.Parse(xVal);
            Console.Clear();

            Console.WriteLine("Enter y value (1 - 3): ");
            string yVal = Console.ReadLine();
            int yValue = int.Parse(yVal);
            Console.Clear();

            int x = xValue - 2;
            int y = yValue - 2;

            if (x < 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("The enemy is Southwest!");
                }
                if (y == 0)
                {
                    Console.WriteLine("The enemy is West!");
                }
                if (y > 0)
                {
                    Console.WriteLine("The enemy is Northwest!");
                }
            }
            if (x == 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("The enemy is South!");
                }
                if (y == 0)
                {
                    Console.WriteLine("The enemy is in the Center!");
                }
                if (y > 0)
                {
                    Console.WriteLine("The enemy is North!");
                }
            }
            if (x > 0)
            {
                if (y < 0)
                {
                    Console.WriteLine("The enemy is Southeast!");
                }
                if (y == 0)
                {
                    Console.WriteLine("The enemy is East!");
                }
                if (y > 0)
                {
                    Console.WriteLine("The enemy is NorthEast!");
                }
            }
            Console.ReadLine();
        }
    }
}