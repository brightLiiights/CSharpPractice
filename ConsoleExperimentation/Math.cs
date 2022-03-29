namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
            //    Console.Title = "PlaceHolder";
            //    Console.WriteLine("Press any key to continue..");
            //    Console.ReadKey(true);
            //    Console.Clear();
            Console.Title = ("Buying Inventory");
            Console.WriteLine("Buying Inventory, press any key to continue..");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Hello, what is your name? ");
            string personName = Console.ReadLine();

            Console.WriteLine($"What do you want to know the price of {0}? ", personName);

            Console.WriteLine("1. Rope\n" +
                "2. Torches\n" +
                "3. Climbing Equpiment\n" +
                "4. Clean Water\n" +
                "5. Machete\n" +
                "6. Canoe\n" +
                "7. Food Supplies");
            string stringChoice = Console.ReadLine();
            int choice = int.Parse(stringChoice);

            if (personName == "Alex")
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Rope costs 5 gold.");
                        break;
                    case 2:
                        Console.WriteLine("Torches costs 7.5 gold.");
                        break;
                    case 3:
                        Console.WriteLine("Climbing Equipment costs 12.5 gold.");
                        break;
                    case 4:
                        Console.WriteLine("Clean Water costs  .5 gold.");
                        break;
                    case 5:
                        Console.WriteLine("Machete costs 10 gold.");
                        break;
                    case 6:
                        Console.WriteLine("Canoe costs 100 gold.");
                        break;
                    case 7:
                        Console.WriteLine("Food Supplies costs .5 gold.");
                        break;
                    default:
                        Console.WriteLine("I don't quite understand..");
                        break;
                }
            }
            else
            {
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
            }
            Console.ReadLine();
        }
    }
}