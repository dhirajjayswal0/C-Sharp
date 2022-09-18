using System;

namespace Constants
{
    // Constants are immutable valueswhich are known at the compile time.
    // They do not change for the life of the program.

    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // Create a constant of type string with ypur birthday as its value
        const string birthday = "29.03.1998";

        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(weeks);
            Console.WriteLine(birthday);
            Console.ReadLine();
        }
    }
}

