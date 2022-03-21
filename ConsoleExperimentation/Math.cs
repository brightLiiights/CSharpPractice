namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
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

            Console.WriteLine("Hello King!");
            Console.WriteLine("Enter the amount of estates you own: ");

            string estates = Console.ReadLine();
            int numberOfEstates = int.Parse(estates);

            Console.WriteLine("Enter the amount of duchies you own: ");

            string duchies = Console.ReadLine();
            int numberOfDuchies = int.Parse(duchies);

            Console.WriteLine("Lastly, enter the number of Provinces you hold: ");

            string provinces = Console.ReadLine();
            int numberOfProvinces = int.Parse(provinces);

            int estatePoints = 1 * numberOfEstates;
            int duchiesPoints = 3 * numberOfDuchies;
            int provincesPoints = 6 * numberOfProvinces;

            int kingdomPoints = estatePoints + duchiesPoints + provincesPoints;

            Console.WriteLine("Given all the information you have provided, you my sir have a total of {0} points!", kingdomPoints);
            Console.WriteLine("You should be proud My Lord!");
        }
    }

    public class TriangleArea
    {
        //Area of a triangle method
        public static double triangleArea(double triBase, double triHeight)
        {
            double area = (triBase * triHeight) / 2;

            return area;
        }
    }
}