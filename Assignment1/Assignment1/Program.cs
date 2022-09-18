using System;

namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float floatnum = float.Parse(stringForFloat);
            int intnum = int.Parse(stringForInt);

            Console.WriteLine(floatnum);
            Console.WriteLine(intnum);
            Console.ReadLine();
        }
    }
}

