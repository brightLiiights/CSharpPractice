namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
            Console.Title = "Watchtower";
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

            if (xValue == 1)
            {
                if (yValue == 1)
                {
                    Console.WriteLine("Enemy is South-West!");
                }
                if (yValue == 2)
                {
                    Console.WriteLine("Enemy is West!");
                }
                if (yValue == 3)
                {
                    Console.WriteLine("Enemy is North-West!");
                }

            }
            if (xValue == 2)
            {
                if (yValue == 1)
                {
                    Console.WriteLine("Enemy is South!");
                }
                if (yValue == 2)
                {
                    Console.WriteLine("Enemy is directly in the Center!");
                }
                if (yValue == 3)
                {
                    Console.WriteLine("Enemy is North!");
                }
            }
            if (xValue == 3)
            {
                if (yValue == 1)
                {
                    Console.WriteLine("Enemy is South-East!");
                }
                if (yValue == 2)
                {
                    Console.WriteLine("Enemy is East!");
                }
                if (yValue == 3)
                {
                    Console.WriteLine("Enemy is North-East!");
                }
            }
            Console.ReadLine();
        }
    }
}