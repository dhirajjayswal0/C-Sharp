using System;

namespace Implicit_and_Explicit_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;



            // Explicit conversion
            // cast double to int ;
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;



            // typeConversion
            string myString = myDouble.ToString(); // "13.37"

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.ReadLine();
        }
    }
}

