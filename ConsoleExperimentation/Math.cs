namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
            Console.Title = ("Buying Inventory");
            Console.WriteLine("Buying Inventory, press any key to continue..");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("What do you want to know the price of? ");

            Console.WriteLine("1. Rope\n" +
                "2. Torches\n" +
                "3. Climbing Equpiment\n" +
                "4. Clean Water\n" +
                "5. Machete\n" +
                "6. Canoe\n" +
                "7. Food Supplies");
            string stringChoice = Console.ReadLine();
            int choice = int.Parse(stringChoice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Rope costs 10 gold.");
                    break;
                case 2:
                    Console.WriteLine("Torches costs 15 gold.");
                    break;
                case 3:
                    Console.WriteLine("Climbing Equipment costs 25 gold.");
                    break;
                case 4:
                    Console.WriteLine("Clean Water costs  1 gold.");
                    break;
                case 5:
                    Console.WriteLine("Machete costs 20 gold.");
                    break;
                case 6:
                    Console.WriteLine("Canoe costs 200 gold.");
                    break;
                case 7:
                    Console.WriteLine("Food Supplies costs 1 gold.");
                    break;
                default:
                    Console.WriteLine("I don't quite understand..");
                    break;
            }
            Console.ReadLine();
        }
    }
}