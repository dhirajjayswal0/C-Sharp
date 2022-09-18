using System;

namespace parsing_string_to_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";

            // String can be parse to int using Int32 method.
            int num1 = Int32.Parse(myString);
            int num2 = Int32.Parse(mySecondString);

            int sum = num1 + num2;

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

