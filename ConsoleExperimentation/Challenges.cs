using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExperimentation
{
    public class Challenges
    {

        //--------------------------------Triangle Area(uses Method)------------------------------------------
        //Console.WriteLine("Type in your triangle's base: ");
        //string baseString = Console.ReadLine();
        //double triBase = double.Parse(baseString);

        //Console.WriteLine("Now type int the height: ");
        //string heightString = Console.ReadLine(); 
        //double triHeight = double.Parse(heightString);

        //double triArea = TriangleArea.triangleArea(triBase, triHeight);
        //Console.WriteLine("The area of your triangle is exactly: {0}", triArea);

        //int aBigNumber = int.MaxValue;
        //int aSmallNumber = int.MinValue;

        //Console.WriteLine(aBigNumber);
        //Console.WriteLine(aSmallNumber);


        //---------------------------TheFoursistersAndTheDuckBear-------------------------------
        //Console.WriteLine("How many chocolate eggs were laid by the chickens today? ");
        //string chocEggs = Console.ReadLine();

        //int numberChocEggs = int.Parse(chocEggs);

        //int splitChocEggs = numberChocEggs / 4;

        //int duckBearChocEggs = numberChocEggs % 4;

        //Console.WriteLine("Each sister is to receive {0} eggs!", splitChocEggs);
        //Console.WriteLine("And the Duck Bear is to receive {0} egg(s)! :)", duckBearChocEggs);
        //Console.ReadLine();


        //--------------------------TheDominionOfKings-------------------------------------------
        //Console.WriteLine("Hello King!");
        //    Console.WriteLine("Enter the amount of estates you own: ");

        //    string estates = Console.ReadLine();
        //int numberOfEstates = int.Parse(estates);

        //Console.WriteLine("Enter the amount of duchies you own: ");

        //    string duchies = Console.ReadLine();
        //int numberOfDuchies = int.Parse(duchies);

        //Console.WriteLine("Lastly, enter the number of Provinces you hold: ");

        //    string provinces = Console.ReadLine();
        //int numberOfProvinces = int.Parse(provinces);

        //int estatePoints = 1 * numberOfEstates;
        //int duchiesPoints = 3 * numberOfDuchies;
        //int provincesPoints = 6 * numberOfProvinces;

        //int kingdomPoints = estatePoints + duchiesPoints + provincesPoints;

        //Console.WriteLine("Given all the information you have provided, you my sir have a total of {0} points!", kingdomPoints);
        //    Console.WriteLine("You should be proud My Lord!");

        //----------------------------------------Level 8----------------------------------------
        //--------------------------------The Defense of Consolas--------------------------------
        //Console.Title = "Defense of Consolas";

        //Console.WriteLine("Welcome to the Defense of Consolas!");
        //Console.Write("Press Any Key to Continue..");
        //Console.ReadKey(true);
        //Console.Clear();
        //Console.Write("Target Row? ");
        //string tRow = Console.ReadLine();
        //int targetRow = int.Parse(tRow);

        //Console.Write("Target Column: ");
        //string tColumn = Console.ReadLine();
        //int targetColumn = int.Parse(tColumn);

        ////( x, y ) (row, column)
        ////North
        //int northRow = targetRow + 0;
        //int northColumn = targetColumn + 1;
        //string northBlock = $"({northRow},{northColumn})";
        ////East
        //int eastRow = targetRow + 1;
        //int eastColumn = targetColumn + 0;
        //string eastBlock = $"({eastRow},{eastColumn})";
        ////South
        //int southRow = targetRow + 0;
        //int southColumn = targetColumn -1;
        //string southBlock = $"({southRow},{southColumn})";
        ////West
        //int westRow = targetRow - 1;
        //int westColumn = targetColumn - 0;
        //string westBlock = $"({westRow},{westColumn})";

        //Console.WriteLine($"Deploy to:\n" +
        //    $"{northBlock}\n" +
        //    $"{eastBlock}\n" +
        //    $"{southBlock}\n" +
        //    $"{westBlock}");

        //Console.WriteLine("The Defense system worked!");
        //Console.ReadLine();

    }

    //public class TriangleArea (Challenge)
    //{
    //    //Area of a triangle method
    //    public static double triangleArea(double triBase, double triHeight)
    //    {
    //        double area = (triBase * triHeight) / 2;

    //        return area;
    //    }
    //}
}
