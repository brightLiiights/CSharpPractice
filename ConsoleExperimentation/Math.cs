namespace ConsoleExperimentation
{
    public static class Math
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in your triangle's base: ");
            string baseString = Console.ReadLine();
            double triBase = double.Parse(baseString);

            Console.WriteLine("Now type int the height: ");
            string heightString = Console.ReadLine(); 
            double triHeight = double.Parse(heightString);

            double triArea = TriangleArea.triangleArea(triBase, triHeight);
            Console.WriteLine("The area of your triangle is exactly: {0}", triArea);
        }
    }

    public class TriangleArea
    {
        public static double triangleArea(double triBase, double triHeight)
        {
            double area = (triBase * triHeight) / 2;

            return area;
        }
    }
}