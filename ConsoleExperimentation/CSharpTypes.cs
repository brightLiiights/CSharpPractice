using System;

namespace ConsoleExperimentation
{
    public static class CSharpTypes
    {
        public static void Main(string[] args) 
        {
            //Byte: No Negatives/ Min: 0, Max: 255 = 1 Byte
            byte ghostByte = 1;
            //SByte: Min: -128, Max: 127 = 1 Byte
            sbyte ghostSByte = -1;
            //Short: Min:-32,768, Max: 32,767 = 2 Bytes
            short ghostShort = 2;
            //UShort: No Negatives, Min: 0, Max: 65,535
            ushort ghostUShort = 2;
            //Int: Min: -2,147,483,648, Max: 2,147,483,647 = 4 Bytes
            int ghostInt = 3; 
            //UInt: No Negatives, Min: 0, Max: 4,294,967,295
            uint ghostUInt = 3;
            //Long: Min: -5 Quintillion, Max: 5 Quintillion = 8 Bytes
            long ghostLong = 4;
            ulong ghostULong = 4;
            //Digits of Precision: 7
            float ghostFloat = 5.0122121F;
            //Digits of Precision: 15-16
            double ghostDouble = 5.123459676;
            //Digits of Precision: 28-29
            decimal ghostDecimal = 5.123213435M;

            bool ghostBool = false;

            string ghostString = "i'm a string!";

            char ghostChar = 'a';

            var ghostVar = "324254";


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