namespace ConsoleExperimentation
{
    public static class CSharpTypes
    {
        public static void Main(string[] args)
        {
            //'ghost' keyword has no specific meaning.
            //It was the first thing that came to mind when writing this program

            //Byte: No Negatives/ Min: 0, Max: 255 = 1 Byte
            byte ghostByte = 1;
            ghostByte = 2;
            //SByte: Min: -128, Max: 127 = 1 Byte
            sbyte ghostSByte = -1;
            ghostSByte = -2;
            //Short: Min:-32,768, Max: 32,767 = 2 Bytes
            short ghostShort = 2;
            ghostShort = 3;
            //UShort: No Negatives, Min: 0, Max: 65,535
            ushort ghostUShort = 2;
            ghostUShort = 3;
            //Int: Min: -2,147,483,648, Max: 2,147,483,647 = 4 Bytes
            int ghostInt = 3;
            ghostInt = 4;
            //UInt: No Negatives, Min: 0, Max: 4,294,967,295
            uint ghostUInt = 3;
            ghostUInt = 4;
            //Long: Min: -5 Quintillion, Max: 5 Quintillion = 8 Bytes
            long ghostLong = 4;
            ghostLong = 5;
            ulong ghostULong = 4;
            ghostULong = 5;
            //Digits of Precision: 7
            float ghostFloat = 5.0122121F;
            ghostFloat = 5.23232F;
            //Digits of Precision: 15-16
            double ghostDouble = 5.123459676;
            ghostDouble = 545545.23423;
            //Digits of Precision: 28-29
            decimal ghostDecimal = 5.123213435M;
            ghostDecimal = 3453636.423423525M;

            bool ghostBool = false;
            ghostBool = true;

            string ghostString = "i'm a string!";
            ghostString = "I'm still a string!";

            char ghostChar = 'a';
            ghostChar = 'b';

            var ghostVar = "324254";
            ghostVar = "3555444";


            Console.WriteLine("Hello World!");
            Console.WriteLine("{0}{1}{2}{3}{4}{5}{5}{6}{7}{8}{9}{10}{11}{12}{13}",
                ghostByte,
                ghostSByte,
                ghostShort,
                ghostUShort,
                ghostInt,
                ghostUInt,
                ghostLong,
                ghostULong,
                ghostFloat,
                ghostDouble,
                ghostDecimal,
                ghostBool,
                ghostString,
                ghostChar,
                ghostVar);
            Console.ReadLine();
        }
    }
}