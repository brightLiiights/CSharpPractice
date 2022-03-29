//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleExperimentation
//{
//    public class Challenges
//    {

//        //--------------------------------Triangle Area(uses Method)------------------------------------------
//        //Console.WriteLine("Type in your triangle's base: ");
//        //string baseString = Console.ReadLine();
//        //double triBase = double.Parse(baseString);

////Console.WriteLine("Now type int the height: ");
////string heightString = Console.ReadLine(); 
////double triHeight = double.Parse(heightString);

////double triArea = TriangleArea.triangleArea(triBase, triHeight);
////Console.WriteLine("The area of your triangle is exactly: {0}", triArea);

////int aBigNumber = int.MaxValue;
////int aSmallNumber = int.MinValue;

////Console.WriteLine(aBigNumber);
////Console.WriteLine(aSmallNumber);


////---------------------------TheFoursistersAndTheDuckBear-------------------------------
////Console.WriteLine("How many chocolate eggs were laid by the chickens today? ");
////string chocEggs = Console.ReadLine();

////int numberChocEggs = int.Parse(chocEggs);

////int splitChocEggs = numberChocEggs / 4;

////int duckBearChocEggs = numberChocEggs % 4;

////Console.WriteLine("Each sister is to receive {0} eggs!", splitChocEggs);
////Console.WriteLine("And the Duck Bear is to receive {0} egg(s)! :)", duckBearChocEggs);
////Console.ReadLine();


////--------------------------TheDominionOfKings-------------------------------------------
////Console.WriteLine("Hello King!");
////    Console.WriteLine("Enter the amount of estates you own: ");

////    string estates = Console.ReadLine();
////int numberOfEstates = int.Parse(estates);

////Console.WriteLine("Enter the amount of duchies you own: ");

////    string duchies = Console.ReadLine();
////int numberOfDuchies = int.Parse(duchies);

////Console.WriteLine("Lastly, enter the number of Provinces you hold: ");

////    string provinces = Console.ReadLine();
////int numberOfProvinces = int.Parse(provinces);

////int estatePoints = 1 * numberOfEstates;
////int duchiesPoints = 3 * numberOfDuchies;
////int provincesPoints = 6 * numberOfProvinces;

////int kingdomPoints = estatePoints + duchiesPoints + provincesPoints;

////Console.WriteLine("Given all the information you have provided, you my sir have a total of {0} points!", kingdomPoints);
////    Console.WriteLine("You should be proud My Lord!");

////----------------------------------------Level 8----------------------------------------
////--------------------------------The Defense of Consolas--------------------------------
////Console.Title = "Defense of Consolas";

////Console.WriteLine("Welcome to the Defense of Consolas!");
////Console.Write("Press Any Key to Continue..");
////Console.ReadKey(true);
////Console.Clear();
////Console.Write("Target Row? ");
////string tRow = Console.ReadLine();
////int targetRow = int.Parse(tRow);

////Console.Write("Target Column: ");
////string tColumn = Console.ReadLine();
////int targetColumn = int.Parse(tColumn);

//////( x, y ) (row, column)
//////North
////int northRow = targetRow + 0;
////int northColumn = targetColumn + 1;
////string northBlock = $"({northRow},{northColumn})";
//////East
////int eastRow = targetRow + 1;
////int eastColumn = targetColumn + 0;
////string eastBlock = $"({eastRow},{eastColumn})";
//////South
////int southRow = targetRow + 0;
////int southColumn = targetColumn -1;
////string southBlock = $"({southRow},{southColumn})";
//////West
////int westRow = targetRow - 1;
////int westColumn = targetColumn - 0;
////string westBlock = $"({westRow},{westColumn})";

////Console.WriteLine($"Deploy to:\n" +
////    $"{northBlock}\n" +
////    $"{eastBlock}\n" +
////    $"{southBlock}\n" +
////    $"{westBlock}");

////Console.WriteLine("The Defense system worked!");
////Console.ReadLine();


////----------------Repairing the Clocktower---------------------
////Console.Title = "Repairing the Clocktower";
////Console.WriteLine("Welcome to Repair the Clocktower! ");
////Console.Write("Press any key to continue: ");
////Console.ReadKey(true);
////Console.Clear();

////Console.Write("Enter an integer: ");
////string uNumber = Console.ReadLine();
////int userNumber = int.Parse(uNumber);
////int finalNumber = userNumber % 2;
////if (finalNumber == 0)
////{
////    //Even
////    Console.WriteLine("Tick");
////}
////else
////{
////    //Odd
////    Console.WriteLine("Tock");
////}
////Console.ReadLine();

////---------------------------------WatchTower---------------------------------------------
////        Console.Title = "Watchtower";
////            Console.WriteLine("Press Any Key to Continue.. ");
////            Console.ReadKey(true);
////            Console.Clear();

////            Console.WriteLine("Enter x value (1 - 3): ");
////            string xVal = Console.ReadLine();
////        int xValue = int.Parse(xVal);
////        Console.Clear();

////            Console.WriteLine("Enter y value (1 - 3): ");
////            string yVal = Console.ReadLine();
////        int yValue = int.Parse(yVal);
////        Console.Clear();

////            if (xValue == 1)
////            {
////                if (yValue == 1)
////                {
////                    Console.WriteLine("Enemy is South-West!");
////                }
////                if (yValue == 2)
////                {
////                    Console.WriteLine("Enemy is West!");
////                }
////if (yValue == 3)
////{
////    Console.WriteLine("Enemy is North-West!");
////}

////            }
////            if (xValue == 2)
////{
////    if (yValue == 1)
////    {
////        Console.WriteLine("Enemy is South!");
////    }
////    if (yValue == 2)
////    {
////        Console.WriteLine("Enemy is directly in the Center!");
////    }
////    if (yValue == 3)
////    {
////        Console.WriteLine("Enemy is North!");
////    }
////}
////if (xValue == 3)
////{
////    if (yValue == 1)
////    {
////        Console.WriteLine("Enemy is South-East!");
////    }
////    if (yValue == 2)
////    {
////        Console.WriteLine("Enemy is East!");
////    }
////    if (yValue == 3)
////    {
////        Console.WriteLine("Enemy is North-East!");
////    }
////}
////Console.ReadLine();
////////////////////////////////////WatchTower 2////////////////////////////////////////


////        Console.Title = "Watchtower";
////            Console.WriteLine("Press Any Key to Continue.. ");
////            Console.ReadKey(true);
////            Console.Clear();

////            Console.WriteLine("Enter x value (1 - 3): ");
////            string xVal = Console.ReadLine();
////        int xValue = int.Parse(xVal);
////        Console.Clear();

////            Console.WriteLine("Enter y value (1 - 3): ");
////            string yVal = Console.ReadLine();
////        int yValue = int.Parse(yVal);
////        Console.Clear();

////            int x = xValue - 2;
////        int y = yValue - 2;

////            if (x< 0)
////            {
////                if (y< 0)
////                {
////                    Console.WriteLine("The enemy is Southwest!");
////                }
////                if (y == 0)
////                {
////                    Console.WriteLine("The enemy is West!");
////                }
////if (y > 0)
////{
////    Console.WriteLine("The enemy is Northwest!");
////}
////            }
////            if (x == 0)
////{
////    if (y < 0)
////    {
////        Console.WriteLine("The enemy is South!");
////    }
////    if (y == 0)
////    {
////        Console.WriteLine("The enemy is in the Center!");
////    }
////    if (y > 0)
////    {
////        Console.WriteLine("The enemy is North!");
////    }
////}
////if (x > 0)
////{
////    if (y < 0)
////    {
////        Console.WriteLine("The enemy is Southeast!");
////    }
////    if (y == 0)
////    {
////        Console.WriteLine("The enemy is East!");
////    }
////    if (y > 0)
////    {
////        Console.WriteLine("The enemy is NorthEast!");
////    }
////}

////Console.ReadLine();
///////////////////////////////////////////////////////////////
///Buying Inventory--------------------------------------------------
/////
//Console.Title = ("Buying Inventory");
//Console.WriteLine("Buying Inventory, press any key to continue..");
//Console.ReadKey(true);
//Console.Clear();

//Console.WriteLine("What do you want to know the price of? ");

//Console.WriteLine("1. Rope\n" +
//    "2. Torches\n" +
//    "3. Climbing Equpiment\n" +
//    "4. Clean Water\n" +
//    "5. Machete\n" +
//    "6. Canoe\n" +
//    "7. Food Supplies");
//string stringChoice = Console.ReadLine();
//int choice = int.Parse(stringChoice);

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Rope costs 10 gold.");
//        break;
//    case 2:
//        Console.WriteLine("Torches costs 15 gold.");
//        break;
//    case 3:
//        Console.WriteLine("Climbing Equipment costs 25 gold.");
//        break;
//    case 4:
//        Console.WriteLine("Clean Water costs  1 gold.");
//        break;
//    case 5:
//        Console.WriteLine("Machete costs 20 gold.");
//        break;
//    case 6:
//        Console.WriteLine("Canoe costs 200 gold.");
//        break;
//    case 7:
//        Console.WriteLine("Food Supplies costs 1 gold.");
//        break;
//    default:
//        Console.WriteLine("I don't quite understand..");
//        break;
//}
//Console.ReadLine();

////}

////public class TriangleArea (Challenge)
////{
////    //Area of a triangle method
////    public static double triangleArea(double triBase, double triHeight)
////    {
////        double area = (triBase * triHeight) / 2;

////        return area;
////    }
////}
////   }
